using System;
using System.IO;

namespace Metoder_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("");
            Console.WriteLine("            H1 Queue Operations Menu");
            Console.WriteLine("");
            Console.WriteLine("==================================================");
            Console.WriteLine("");
            Console.WriteLine("1. Add file \n2. Delete file \n3. Display files\n4. Add folder\n5. Search for file in folder\n6. Exit");

            string filename;
            string foldername;

            Console.WriteLine("Indtast dit valg");
            int choice = int.Parse(Console.ReadLine());

            
                switch (choice)
                {
                    case 1:
                    Console.WriteLine("Indtast Filnavn");
                    filename = Console.ReadLine();
                    CreateFile(filename);
                        
                        break;
                    case 2:
                    Console.WriteLine("Navn på Fil du vil slette");
                    filename = Console.ReadLine();
                    DeleteFile(filename);
                    
                        break;
                    case 3:
                    ShowFiles();

                        break;
                    case 4:
                    Console.WriteLine("Indtast ønsket navn på mappe");
                    foldername = Console.ReadLine();
                    CreateFolder(foldername);

                        break;
                    case 5:
                    Console.WriteLine("Indtast navnet på mappen");
                    foldername= Console.ReadLine();
                    Console.WriteLine("Indtast navnet på filen");
                    filename = Console.ReadLine();
                    SearchFolder(filename, foldername);
                        break;
                    case 6:
                    return;
                         default:
                        break;
                }

            

            Console.ReadKey();

        }

        public static void CreateFile(string filename)
        {
            File.Create(@$".\{filename}.txt");
        }

        public static void DeleteFile(string filename)
        {
            File.Delete($@".\{filename}.txt");
        }

        public static void ShowFiles()
        {
            string[] contents = Directory.GetFiles(@".\", "*.txt", SearchOption.AllDirectories);

            foreach (string i in contents)
            {
                Console.WriteLine(i);
            }
        }

        public static void CreateFolder(string foldername)
        {
            Directory.CreateDirectory($@".\{foldername}");
        }

        public static void SearchFolder(string filename, string foldername)
        {
            string [] contents = Directory.GetFiles($@".\{foldername}", $"{filename}*", SearchOption.AllDirectories);

            foreach (string i in contents)
            {
                Console.WriteLine(i);
            }
        }


    }
}
