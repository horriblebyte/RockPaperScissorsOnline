using System;
using System.Net;
using System.Net.Sockets;

using ServerRPS.Utils;
using ServerRPS.Classes.Models;
using ServerRPS.Classes.Managers;

namespace ServerRPS.Classes {
    public class Listener {

        //Ana sunucu soketi ve nitelikleri.
        public Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        /// <summary>
        /// Sunucuyu başlatan metot.
        /// </summary>
        /// <param name="portNumber">Dinlenecek Port numarası.</param>
        /// <param name="backLog">Bağlantı kuyruğundaki kişi sayısının limiti.</param>
        public void Start(int portNumber, int backLog) {
            try {
                serverSocket.Bind(new IPEndPoint(IPAddress.Any, portNumber));
                serverSocket.Listen(backLog);
                serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
                Logger.LogWarning("Sunucu başlatıldı!");
                Logger.LogWarning($"Bağlantı bilgisi: {AllUtils.GetMachineLocalIP()}:{portNumber}");
            } catch (Exception appException) {
                Logger.LogError(string.Format("Start() Hata: {0}", appException.Message));
            }
        }

        private void AcceptCallback(IAsyncResult ar) {

            Socket currentSocket = (Socket)ar.AsyncState;

            try {
                currentSocket = serverSocket.EndAccept(ar);
            } catch (Exception) {
                return;
            }

            //Socket nesnesinin özelliklerini, Client modelindeki Socket nesnesine aktarıyoruz.
            Client clientObject = new Client() {
                ClientSocket = currentSocket
            };

            //Client nesnesiyle de yeni bir player oluşturuyoruz. Artık oluşan player nesnesi bu bağlantıyı temsil edecek.
            Player currentPlayer = PlayerManager.CreatePlayer(clientObject);

            //Player nesnesini dinlemeye başlıyoruz.
            Receiver.Receive(currentPlayer);

            //Oyuncunun oyuna katıldığının bilgisini veriyoruz.
            Logger.LogWarning(string.Format("{0} ID'li oyuncu, sunucuya katıldı!", currentPlayer.PlayerID));

            //Bağlantı sürekliliğinin sağlanabilmesi için bağlantı isteklerini kabul etmeye devam ediyoruz.
            serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }
    }
}