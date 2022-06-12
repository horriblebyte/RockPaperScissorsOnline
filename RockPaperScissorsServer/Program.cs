using System;
using System.Diagnostics;
using System.Threading.Tasks;

using ServerRPS.Classes;
using ServerRPS.Classes.Managers;

namespace ServerRPS {
    public class Program {
        private static void Main() {
            Console.Title = "Taş Kağıt Makas Server";
            Logger.CheckLogDirectory();
            Listener listenerObject = new Listener();
            listenerObject.Start(1881, 500);
            TitleRefresher(500);
            Process.GetCurrentProcess().WaitForExit();
        }

        /// <summary>
        /// Konsolun başlığına oyuncu, oda ve RAM durumunu yazdırır.
        /// </summary>
        /// <param name="refreshTimeMS">Yenilemenin hızını milisaniye türünden belirler.</param>
        private static async void TitleRefresher(int refreshTimeMS) {
            while (true) {
                Console.Title = string.Format("Taş Kağıt Makas Server - Çevrimiçi Oyuncular: {0}, Açık Odalar: {1}, Kullanılan RAM: {2} KB", PlayerManager.GetPlayerCount(), RoomManager.GetRoomCount(), (GC.GetTotalMemory(true) / 1024));
                await Task.Delay(refreshTimeMS);
            }
        }
    }
}