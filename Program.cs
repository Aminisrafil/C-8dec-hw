using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.Cryptography;

namespace _8dec_hw
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Verilmiş M dəyərindən verilmiş N dəyərinədək 21 - ə bölünən ədədlərin ədədi ortasını tapan proqram

            int sum = 0;
            int count = 0;

            Console.WriteLine("1ci ededi daxil edin:");
            var numMStr = Console.ReadLine();
            var numM = Convert.ToInt32(numMStr);

            Console.WriteLine("2ci ededi daxil edin:");
            var numNStr = Console.ReadLine();
            var numN = Convert.ToInt32(numNStr);


            while (numM < numN)
            {

                if (numM % 21 == 0)
                {
                    sum += numM;
                    count++;
                    numM++;

                }
                else
                {
                    numM++;
                }


            }
            if (count == 0)
            {
                Console.WriteLine("0a bolmek olmaz");
            }
            else
            {
                Console.WriteLine(sum / count);
            }

            Console.WriteLine("=============================================");
            ////Verilmiş ədədin rəqəmləri cəmini tapan proqram
            Console.WriteLine("Eded daxil edin");
            var numStr = Console.ReadLine();

            var num = Convert.ToInt32(numStr);

            var total = 0;



            while (num != 0)
            {
                var x = num % 10;
                total += x;
                num = (num - x) / 10;

            }
            Console.WriteLine(total);

            Console.WriteLine("========================================================");
            ////Verilmiş ayın ədədinə görə hansı fəsil olduğunu tapan proqram


            Console.WriteLine("Ededi daxil edin");
            var ededd = Console.ReadLine();
            var eded = Convert.ToInt32(ededd);

            if (eded < 1 || eded > 12)
            {
                Console.WriteLine("Zehmet olmasa 1 ve 12 araliginda eded daxil edin");

            }
            else if (eded == 12 || eded == 1 || eded == 2)
            {
                Console.WriteLine("Qis");
            }
            else if (eded == 3 || eded == 4 || eded == 5)
            {
                Console.WriteLine("Yaz");
            }
            else if (eded == 6 || eded == 7 || eded == 8)
            {
                Console.WriteLine("Yay");

            }
            else
            {
                Console.WriteLine("Payiz");
            }
            Console.WriteLine("================================================");
            //Verilmiş yazıda rəqəm olmamasını yoxlayan proqram, əgər rəqəm varsa yenidən yazının daxil edilməsini istəməlidir ta ki rəqəmsiz daxil edilənədək.



            string array = "0123456789";


            var has = true;

            do
            {
                var yazi = Console.ReadLine();

                for (int j = 0; j < yazi.Length; j++)
                {



                    for (int i = 0; i < array.Length; i++)
                    {

                        if (array[i] == yazi[j])
                        {

                            Console.WriteLine("yazida reqem var yeniden yoxlayin");
                            has = false;
                            break;

                        }
                        else
                        {
                            has = true;
                        }

                    }
                    if (has == false)
                    {
                        break;
                    }





                }
            } while (has == false);

            if (has)
            {
                Console.WriteLine("yazida reqem yoxdu");

                Console.WriteLine("========================================================================");

                //Verilmiş 2 ədəd üzərində verilmiş operator simvoluna uyğun riyazi əməliyyat aparan proqram.
                //Misalçün consoledan 5,10 və + daxil edilsə 5 və 10 - u toplayıb nəticəsini göstərsin.
                //Console - dan daxil edilən operator + , -, *, / operatorlarından biri deyilsə operator yanlışdır yazılsın.

                Console.WriteLine("Qaqa zehmet olmasa ededi daxil ederdindee");
                string num1 = Console.ReadLine();
                var Num1 = Convert.ToInt32(num1);



                Console.WriteLine("Qaqa zehmet olmasa neyniyeciyik onuda deyerdindee");
                string num2 = Console.ReadLine();
                var Num2 = Convert.ToChar(num2);



                Console.WriteLine("Qaqa zehmet olmasa axrincinida de fso");
                string num3 = Console.ReadLine();
                var Num3 = Convert.ToInt32(num3);

                if (Num2 == '+')
                {
                    Console.WriteLine(Num1 + Num3);
                }
                if (Num2 == '-')
                {
                    Console.WriteLine(Num1 - Num3);
                }
                if (Num2 == '*')
                {
                    Console.WriteLine(Num1 * Num3);
                }
                if (Num2 == '/')
                {
                    Console.WriteLine(Num1 / Num3);
                }



















































































































































            }

























        }
    }
}




