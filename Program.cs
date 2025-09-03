using System;
using System.IO;

namespace Chirp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Data", "chirp_cli_db.csv");

            
            choose(path);
            
            Console.Beep();
        }

        static void choose(string  path)
        {
            Console.WriteLine("write 'view' to see chirps - write 'write' to make a chirps" );
            Console.WriteLine("write 'exit' to exit ");
            
            String choice = Console.ReadLine();
            
            if (choice == "write")
            {
                save(path);
            }

            if (choice == "view")
            {
                read(path);
            }

            if (choice == "exit")
            {
                return;
            }
            
            
        }

        static void save(string path)
        {
            Console.WriteLine("write 'exit' to exit ");
            Console.WriteLine("Write your chirp - press enter when you're done");
                
                using (StreamWriter sw = File.AppendText(path))
                {
                    string chirp = Console.ReadLine();
                    if (chirp == "exit")
                    {
                        return;
                    }
                    sw.Write(Environment.UserName + " @ ");
                    sw.Write(DateTime.Now.ToString() + ": ");
                    sw.WriteLine(chirp);
                    
                    
                    Console.WriteLine(" the chirp: " + chirp + " was saved");
                }

                choose(path);
        }

        static void read(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.Write(s + "\n");
                }
            }
            choose(path);
        }
    }
}