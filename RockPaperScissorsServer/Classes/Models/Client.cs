using System.Net.Sockets;

namespace ServerRPS.Classes.Models {
    public class Client {
        // İstemci soketi.
        public Socket ClientSocket = null;
        // Alıcı byte tamponunun boyutu.
        public const int ReceiveByteBufferSize = 1024;
        // Alıcı byte tamponu.
        public byte[] ReceiveByteBuffer = new byte[ReceiveByteBufferSize];
    }
}