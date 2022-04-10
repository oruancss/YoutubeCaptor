using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary;

namespace YoutubeCaptor
{
    class Program
    {

        static void Main(string[] args)
        {
            var version = "1.4";
            var pastaDownload = @"Downloads";
            var youtube = YouTube.Default;
            bool emLoop = true;
            string link;

            Console.Title = $"YoutubeCaptor V{version}";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                                                                                        ");
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", $"▄███████████▄"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", $"█████░▀██████"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", $"█████░░░▀████"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", $"█████░░░▄████"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", $"                           █████░▄██████ YoutubeCaptor V{version}"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", $"                           █████████████ Ruan C."));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", $"─▀▀▀▀▀▀▀▀▀▀▀─"));
            Console.WriteLine("                                                                                                        ");
            Console.ForegroundColor = ConsoleColor.White;

            do
            {
                Console.Write("YouTube Link > ");
                link = Console.ReadLine();

                if (!Directory.Exists(pastaDownload)) { //Verifica se a pasta de downloads existe.
                    Directory.CreateDirectory(pastaDownload);
                }

                var video = youtube.GetAllVideosAsync(link).GetAwaiter().GetResult();
                var resolucaoVideo = video.FirstOrDefault(v => v.Resolution == 360); //var resolucaoMaxima = video.First(i => i.Resolution == video.Max(j => j.Resolution));
                File.WriteAllBytes(@"Downloads/" + resolucaoVideo.FullName, resolucaoVideo.GetBytes());
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Download finalizado!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                    ");
            } while (emLoop == true);
        }
    }
}
