using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic8ball
{
    //class Jorden
    //{
    //    public static String name = "Jorden";
    //    public static String alias = "Van Valckenborgh";
    //    public static int age = 16;
    //}

        /// <summary>
        /// jipie we gaan 8 ball maken
        /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // andere dinges
            ConsoleColor kleur = Console.ForegroundColor;
            
            titel();
            Console.WriteLine("");

            Random random = new Random();

            //loop 

            while (true)
            {
                //de vraag en het antwoord
                string vraag = gesteldevraag();

                int slaapseconden = random.Next(4) + 1;
                Console.WriteLine("Even denken...");
                Thread.Sleep(slaapseconden * 1000);
                
                if (vraag.Length == 0)
                {

                    Console.WriteLine("Dat is geen vraag!!");
                    continue;
                }



                if (vraag.ToLower() == "quit")
                {
                    break;
                }
                
                
                

               
                
                //random nummer
                int randomnummer = random.Next(4);

                //antwoord op random nummer

                switch (randomnummer)
                {
                    case 0:
                    
                            Console.WriteLine("100% Ja");
                            break;

                    

                    case 1:
                    
                            Console.WriteLine("nee!");
                            break;
                    

                    case 2:
                    
                            Console.WriteLine("misschien");
                            break;
                    

                    case 3:
                    
                            Console.WriteLine("nooit!");
                            break;
                                    }

            }
            //Opkuis

            Console.ForegroundColor = kleur;

        }

        static void titel()
        {
            //kleurverandering

            Console.ForegroundColor = ConsoleColor.Green;


            Console.Write("   Magic8ball");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("(door: jorden the beast)");

        }
        
         static string gesteldevraag()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Stel een vraag?: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            String vraag = Console.ReadLine();
            return vraag;
        }


    }
}
