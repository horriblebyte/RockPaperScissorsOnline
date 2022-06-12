using System;
using System.IO;

namespace ServerRPS.Classes {
    public class Logger {

        private static object processSync = new object();
        private static string logFolderName = "logs";
        private static string logFileName = string.Format("{0}.log", DateTime.Now.ToString("dd-MM-yyyy---HH-mm-ss"));

        /// <summary>
        /// Log dizininin olup olmadığını kontrol eder. Yoksa oluşturur.
        /// </summary>
        public static void CheckLogDirectory() {
            if (!Directory.Exists(logFolderName))
                Directory.CreateDirectory(logFolderName);
        }

        /// <summary>
        /// Console ekranına Sarı renkte uyarı mesajı yazdırır.
        /// </summary>
        /// <param name="message">Yazılacak olan mesajdır.</param>
        public static void LogWarning(string message) {
            WriteLog(message, ConsoleColor.Yellow);
        }

        /// <summary>
        /// Console ekranına Turkuaz renkte uyarı mesajı yazdırır.
        /// </summary>
        /// <param name="message">Yazılacak olan mesajdır.</param>
        public static void LogInfo(string message) {
            WriteLog(message, ConsoleColor.Cyan);
        }

        /// <summary>
        /// Console ekranına Magenta renkte uyarı mesajı yazdırır.
        /// </summary>
        /// <param name="message">Yazılacak olan mesajdır.</param>
        public static void LogFightInfo(string message) {
            WriteLog(message, ConsoleColor.Magenta);
        }

        /// <summary>
        /// Console ekranına Kırmızı renkte uyarı mesajı yazdırır.
        /// </summary>
        /// <param name="message">Yazılacak olan mesajdır.</param>
        public static void LogError(string message) {
            WriteLog(message, ConsoleColor.Red);
        }

        /// <summary>
        /// Her türden mesajı yazdırır.
        /// </summary>
        /// <param name="message">Yazılacak olan mesajdır.</param>
        /// <param name="color">Mesajın rengidir.</param>
        private static void WriteLog(string message, ConsoleColor color) {
            lock (processSync) {
                Console.ForegroundColor = color;
                message = string.Format("[{0}] {1}", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"), message);
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.White;
                SaveLog(message);
            }
        }

        /// <summary>
        /// İstenen mesajı log dosyasına yazar.
        /// </summary>
        /// <param name="message">Yazılacak olan mesajdır.</param>
        private static void SaveLog(string message) {
            try {
                string FilePath = string.Format("{0}/{1}", logFolderName, logFileName);
                using (StreamWriter streamWriter = new StreamWriter(FilePath, true)) {
                    if (streamWriter != null)
                        streamWriter.WriteLine(message);
                    streamWriter.Close();
                }
            } catch (Exception appException) {
                Console.WriteLine(appException.Message);
                return;
            }
        }
    }
}