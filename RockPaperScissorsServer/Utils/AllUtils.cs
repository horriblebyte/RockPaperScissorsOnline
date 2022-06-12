using System.Net;
using System.Net.Sockets;

using ServerRPS.Classes;
using ServerRPS.Classes.Models;
using ServerRPS.Classes.Managers;

namespace ServerRPS.Utils {
    public class AllUtils {

        /// <summary>
        /// Oyuncunun bağlantısını kapatır.
        /// </summary>
        /// <param name="playerObject">Bağlantısı kapatılacak olan oyuncu.</param>
        /// <param name="isKicked">True ise zorla çıkmış veya atılmış demektir..</param>
        public static void Disconnect(Player playerObject, bool isKicked) {
            if (playerObject.Connection.ClientSocket.Connected) {
                if (!isKicked)
                    Logger.LogWarning(string.Format("{0} ID'li oyuncunun çıkışı yapıldı.", playerObject.PlayerID));
                playerObject.Connection.ClientSocket.Shutdown(SocketShutdown.Both);
                playerObject.Connection.ClientSocket.Close();
                PlayerManager.RemovePlayer(playerObject);
            }
        }

        /// <summary>
        /// Hamle koduna göre hamlenin adını döndürür.
        /// </summary>
        /// <param name="attackCode">Hamlenin kodu.</param>
        public static string GetAttackNameFromCode(ushort attackCode) {
            switch (attackCode) {
                case 1:
                    return "Taş";
                case 2:
                    return "Kağıt";
                case 3:
                    return "Makas";
                default:
                    return string.Empty;
            }
        }

        public static string GetMachineLocalIP() {
            try {
                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0)) {
                    socket.Connect("8.8.8.8", 65530);
                    IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                    return endPoint.Address.ToString();
                }
            } catch {
                return "";
            }
        }

    }
}