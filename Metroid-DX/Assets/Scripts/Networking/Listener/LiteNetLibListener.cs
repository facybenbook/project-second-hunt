using System;
using System.Net;
using System.Net.Sockets;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;

namespace Networking.Listener
{
    public class LiteNetLibListener: INetListener, INetEventListener
    {
        // General
        private string _ip;
        private int _port;
        private int _tickRate;
    
        // LiteNetLib
        private NetManager _netClient;
        private readonly NetPacketProcessor _packetProcessor;
        private NetPeer _serverPeer;

        public LiteNetLibListener()
        {
            _packetProcessor = new NetPacketProcessor();
        }

        public void Start(string ip, int port, int tickRate, string password = "")
        {
            if (!_netClient.IsRunning)
            {
                _ip = ip;
                _port = port;
                _tickRate = tickRate;
                _netClient.UpdateTime = _tickRate;
                _netClient.Start();
                _netClient.Connect(ip, port, password);
            }
            else
            {
                Debug.LogError("[NETWORKING] Already connected to a server instance!");
            }

        }

        public void Send(byte[] data, DeliveryMethod deliveryMethod)
        {
            _serverPeer.Send(data, deliveryMethod);
        }

        public void Stop()
        {
            // ToDo: Send Disconnected Packet
            _netClient.Stop();
        }

        public void RegisterNestedType<T>(Action<NetDataWriter, T> writeDelegate, Func<NetDataReader, T> readDelegate)
        {
            _packetProcessor.RegisterNestedType(writeDelegate, readDelegate);
        }

        public void SubscribeReusable<T, TUserData>(Action<T, TUserData> onReceive) where T : class, new()
        {
            _packetProcessor.SubscribeReusable(onReceive);
        }

        public void OnPeerConnected(NetPeer peer)
        {
            _serverPeer = peer;
            Debug.Log("[NETWORKING] Connected to " + peer.EndPoint);
        }

        public void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo)
        {
            _serverPeer = null;
            Debug.Log("[NETWORKING] Disconnected from " + peer.EndPoint);
        }

        public void OnNetworkError(IPEndPoint endPoint, SocketError socketError)
        {
            Debug.LogError("[NETWORKING] Error " + socketError);
        }

        public void OnNetworkReceive(NetPeer peer, NetPacketReader reader, DeliveryMethod deliveryMethod)
        {
            _packetProcessor.ReadAllPackets(reader, peer);
        }

        public void OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType)
        {
            throw new NotImplementedException();
        }

        public void OnNetworkLatencyUpdate(NetPeer peer, int latency)
        {
            throw new NotImplementedException();
        }

        public void OnConnectionRequest(ConnectionRequest request)
        {
            request.Reject();
        }
    }
}
