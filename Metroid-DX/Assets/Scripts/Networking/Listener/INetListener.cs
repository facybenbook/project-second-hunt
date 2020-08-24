using System;
using LiteNetLib;
using LiteNetLib.Utils;

namespace Networking.Listener
{
    public interface INetListener
    {
        void Start(string ip, int port, int tickRate, string password = "");
        void Stop();

        void Send(byte[] data, DeliveryMethod deliveryMethod);
    
        /// <summary>
        /// Register nested property type
        /// </summary>
        /// <param name="writeDelegate"></param>
        /// <param name="readDelegate"></param>
        void RegisterNestedType<T>(Action<NetDataWriter, T> writeDelegate, Func<NetDataReader, T> readDelegate);

        /// <summary>
        /// Register and subscribe to packet receive event
        /// This metod will overwrite last received packet class on receive (less garbage)
        /// </summary>
        /// <param name="onReceive">event that will be called when packet deserialized with ReadPacket method</param>
        /// <exception cref="InvalidTypeException"><typeparamref name="T"/>'s fields are not supported, or it has no fields</exception>
        void SubscribeReusable<T, TUserData>(Action<T, TUserData> onReceive) where T : class, new();
    }
}
