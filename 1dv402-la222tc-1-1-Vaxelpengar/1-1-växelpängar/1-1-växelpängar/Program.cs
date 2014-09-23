using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_växelpängar
{
    class Program
    {
        static void Main(string[] args)
        {
            double avrundningssumma, summan, totalsumma;
            int belopp, belopptillbaka, lappar500,
            lappar100, lappar50, lappar20, kronor10, kronor5, kronor1;


            while (true)
            {
                try
                {

                    Console.Write("Ange totalsumma     :");
                    totalsumma = double.Parse(Console.ReadLine());
                    if(totalsumma < 1)
                    {
                        
                        Console.Write("\n");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Totalsumman är för liten! Köpet kunde ej genomföras.");
                        Console.ResetColor();
                        return;
                    }
                    break;
                }

                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel format! Ange rätt format.");
                    Console.ResetColor();
                }
                catch (OverflowException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("För högt tal! Ange ett lägre tal.");
                    Console.ResetColor();
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ett oväntat fel inträffade! Försök igen.");
                    Console.ResetColor();
                }
            }
            Console.WriteLine("\n");


            while (true)
            {
                try
                {
                    Console.WriteLine("Totalsumma          :{0}",totalsumma);
                    Console.Write("Ange erhållet belopp:");
                    belopp = int.Parse(Console.ReadLine());
                    if(totalsumma > belopp)
                    {
                        Console.Write("\n");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Erhållet belopp är för litet! Köpet kunde ej genomföras.");
                        Console.ResetColor();
                        return;
                    }
                    break;
                }

                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel format! Ange rätt format.");
                    Console.ResetColor();
                }
                catch (OverflowException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("För högt tal! Ange ett lägre tal.");
                    Console.ResetColor();
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ett oväntat fel inträffade! Försök igen.");
                    Console.ResetColor();
                }
            }
            Console.WriteLine("\n");

            summan = Math.Round(totalsumma);
            avrundningssumma = totalsumma - summan;

            belopptillbaka = belopp - (int)summan;


            Console.WriteLine("KVITTO");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Totalt           :   {0:C}", totalsumma);
            Console.WriteLine("Öresavrundning   :   {0:C}", avrundningssumma);
            Console.WriteLine("Att betala       :   {0:C0}", summan);
            Console.WriteLine("Kontant          :   {0:C0}", belopp);
            Console.WriteLine("Tillbaka         :   {0:C0}", belopptillbaka);
            Console.WriteLine("-----------------------------");




            Console.WriteLine("\n");

            if (belopptillbaka >= 500)
            {
                lappar500 = belopptillbaka / 500;
                Console.WriteLine("500-lappar   :   {0}", lappar500);
            }

            belopptillbaka = belopptillbaka % 500;

            if( belopptillbaka >= 100)
            {
                lappar100 = belopptillbaka / 100;
                Console.WriteLine("100-lappar   :   {0}", lappar100);
            }

            belopptillbaka = belopptillbaka % 100;

            if(belopptillbaka >= 50)
            {
                lappar50 = belopptillbaka / 50;
                Console.WriteLine("50-lappar    :   {0}", lappar50);
            }

            belopptillbaka = belopptillbaka % 50;

            if(belopptillbaka >= 20)
            {
                lappar20 = belopptillbaka / 20;
                Console.WriteLine("20-lappar    :   {0}", lappar20);
            }

            belopptillbaka = belopptillbaka % 20;

            if(belopptillbaka >= 10)
            {
                kronor10 = belopptillbaka / 10;
                Console.WriteLine("10-kronor    :   {0}", kronor10);

            }

            belopptillbaka = belopptillbaka % 10;

            if(belopptillbaka >= 5)
            {
                kronor5 = belopptillbaka / 5;
                Console.WriteLine("5-kronor     :   {0}", kronor5);
            }

            belopptillbaka = belopptillbaka % 5;

            if (belopptillbaka >= 1)
            {
                kronor1 = belopptillbaka / 1;
                Console.WriteLine("1-kronor     :   {0}", kronor1);
            }
            
           
        }
    }
}
