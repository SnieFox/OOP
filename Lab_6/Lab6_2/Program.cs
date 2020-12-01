using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(@"Введите путь к папке с файлами в формате C:\Users\media");
                    string path = Console.ReadLine();
                    Console.WriteLine("Сканируется папка с файлами..");
                    PlayerItem playerItem = new PlayerItem();
                    playerItem.InitMedia(path);

                    Console.WriteLine("\nВыберите файл:");
                    bool tempParse = int.TryParse(Console.ReadLine(), out int selectedFile);

                    if (selectedFile > 0 && selectedFile < 8)
                    {
                        Console.WriteLine($"Выбранный файл: {playerItem[selectedFile-1]}");
                    }

                    switch (Path.GetExtension(playerItem.media[selectedFile - 1]))
                    {
                        case ".mkv":
                            Mkv mkv = new Mkv();
                            mkv.Play();
                            mkv.Pause();
                            mkv.Stop();
                            break;
                        case ".mp3":
                            Mp3 mp3 = new Mp3();
                            mp3.Record();
                            mp3.Pause();
                            mp3.Stop();
                            break;
                        case ".wav":
                            Wav wav = new Wav();
                            wav.Play();
                            wav.Record();
                            wav.Pause();
                            wav.Stop();
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("\nОшибка. Попробуйте снова.\n\n");
                }
            }
        }
    }
}
