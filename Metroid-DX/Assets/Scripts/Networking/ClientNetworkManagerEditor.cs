using UnityEditor;
using UnityEngine;

namespace Networking
{
    [CustomEditor(typeof(ClientNetworkManager))]
    public class ClientNetworkManagerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            ClientNetworkManager networkManager = (ClientNetworkManager) target;
            if (GUILayout.Button("Connect"))
            {
                networkManager.Connect();
            }

            if (GUILayout.Button("Disconnect"))
            {
                networkManager.Disconnect();
            }
        }
    }
}