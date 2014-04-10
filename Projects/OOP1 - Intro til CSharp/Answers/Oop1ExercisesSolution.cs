using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Oop2012_1
{
    class Oop1Exercises
    {
        static void Main(string[] args)
        {
            //Opgave 1:
            //Opgave1();

            //Opgave2();

            //Opgave3();

            //Opgave4();

            //Opgave5();

            //Opgave6();

            //Opgave 7 - se enum længere nede

            //lotto-numre bruges i opgave 13.
            //Derfor lader vi opgave 8 være en metode der returnerer lotto-tallene.
            //int[] lotteryNumbers = Opgave8();

            //Opgave9();

            //Opgave10();

            //Opgave11();

            //Opgave12();

            //Opgave13(lotteryNumbers);

            //Opgave14();

            //Opgave15();

            Opgave16();

            Console.ReadLine();
        }

        private static void Opgave1()
        {
            Console.WriteLine("Hello World");
        }

        private static void Opgave2()
        {
            //Opgave 2: 
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            Console.WriteLine("Hej " + firstName + " " + lastName);
            //eller
            Console.WriteLine("Hej {0} {1}", firstName, lastName);
        }

        private static void Opgave3()
        {
            //Opgave 3: 
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine()); //play nice
            double result = Math.Sqrt(number);
            //her bliver resultatet formatteret til kun at vise 2 decimaler:
            Console.WriteLine("Kvadratroden af {0} er (ca.) {1:F2}", number, result);

        }

        private static void Opgave4()
        {
            //Opgave 4: 
            //Opgaven kan gribes an på flere måder. Her vises 2 forskellige
            //4.1 - med en string variabel der bliver udbygget
            string s = "";
            for (int i = 1; i <= 5; i++)
            {
                s += "*"; //string konkatenering
                Console.WriteLine(s);
            }
            //4.2 - med en nested for-løkke
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //Samme fremgangsmåde kan benyttes ved while

            string s1 = "";
            int k = 1;
            while (k <= 5)
            {
                s1 += "*";
                Console.WriteLine(s1);
                k++;
            }

            int a = 1;
            while (a <= 5)
            {
                int b = 1;
                while (b <= a)
                {
                    Console.Write("*");
                    b++;
                }
                Console.WriteLine();
                a++;
            }

            //for at udskrive i den modsatte retning tæller vi nedad
            string s2 = "*****";
            for (int i = 5; i >= 1; i--)
            {
                s2 = s2.Substring(0, i);
                Console.WriteLine(s2);
            }
            for (int i = 5; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //osv. for while-løkker også
        }

        private static void Opgave5()
        {
            //Opgave 5:
            //5.1)
            Console.WriteLine(0x12C); //(1*16^2) + (2*16^1) + (12*16^0) 
            //5.2)
            decimal d = 678.5M;
            //5.3)
            //ulong er den eneste heltals type der er stor nok.
            ulong d2 = 9990000000000000000;
            //5.4)
            int id2 = (int)d2; //overflow, derfor mystisk værdi.
            Console.WriteLine(id2);
            //5.5)
            double dd2 = 9.99E18;
            Console.WriteLine("{0:N}", 9990000000000000000);
            Console.WriteLine("{0:N}", dd2);
        }

        private static void Opgave6()
        {
            //char a = "a"; //char værdier skal mellem ' - ikke "
            //bool b = 0; //De 2 eneste lovlige bool værdier er: true og false
            //int c = 8.0; //int kan kun holde heltal
            //decimal d = 6.7; //Mangler M suffiks (6.7M)
            //string e = "Har du set "Avatar"?"; //Mangler escape karakterer foran " tegn: \"

            //Her er de fem rigtige:
            char a = 'a'; //char værdier skal mellem ' - ikke "
            bool b = true; //De 2 eneste lovlige bool værdier er: true og false
            int c = 8; //int kan kun holde heltal
            decimal d = 6.7M; //Mangler M suffiks (6.7M)
            string e = "Har du set \"Avatar\"?"; //Mangler escape karakterer foran " tegn: \"

        }

        //opgave 7
        enum PlayState { Play = 3, Stop, Pause, Record }

        private static int[] Opgave8()
        {
            //Opgave 8:
            //bruger bare 3 elementer her.
            Random r = new Random();
            int[] lotteryNumbers = new int[3];
            lotteryNumbers[0] = r.Next(1, 43);
            lotteryNumbers[1] = r.Next(1, 43);
            lotteryNumbers[2] = r.Next(1, 43);
            //eller vi kunne gøre:
            int[] flereLottoTal = 
            {
                r.Next(1, 43), 
                r.Next(1, 43),
                r.Next(1, 43)
            };

            return lotteryNumbers; //fordi vi bruger lottonumre i en senere opgave
        }

        private static void Opgave9()
        {
            //Opgave 9
            List<string> people = new List<string>();
            people.Add("Kaj");
            people.Add("Bo");
            people.Insert(1, "Ib");
            List<string> flereFolk = new List<string>()
            {
                "Hans", 
                "Grethe"
            };
            people.AddRange(flereFolk);
            people.Remove("Bo");
            people.RemoveAt(2);
            //Kaj, Ib og Grethe er tilbage
            foreach (string person in people)
            {
                Console.WriteLine(person);
            }
        }

        private static void Opgave10()
        {
            //Opgave 10)
            try
            {
                Console.WriteLine("Enter number. Legal or bogus: ");
                int num = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }

            int num2;
            bool bigSuccess = int.TryParse(Console.ReadLine(), out num2);
            if (!bigSuccess)
            {
                Console.WriteLine("Ugyldigt tal");
            }
        }

        private static void Opgave11()
        {
            string s = "The quick brown fox";
            s = s.Replace(' ', '_');
            Console.WriteLine(s);

            string[] ss = s.Split('_');
            foreach (string s1 in ss)
                Console.WriteLine(s1);
        }

        /*
        private static void Opgave12()
        {
            //Opgave 11)
            string tekst = "The quick brown fox";

            bool toUpper = true;
            StringBuilder builder = new StringBuilder();
            char current = ' ';
            foreach (char c in tekst)
            {
                if (toUpper)
                    current = char.ToUpper(c);
                else
                    current = c;
                builder.Append(current);

                if (current == ' ')
                    toUpper = true;
                else
                    toUpper = false;
            }
            string res = builder.ToString();

            //en lidt kortere udgave via conditional operator
            string tekst2 = "The quick brown fox";

            bool toUpper2 = true;
            StringBuilder builder2 = new StringBuilder();
            char current2 = ' ';
            foreach (char c2 in tekst2)
            {
                current2 = toUpper2 ? char.ToUpper(c2) : c2;
                builder2.Append(current2);

                toUpper2 = (current2 == ' ');
            }
            string res2 = builder2.ToString();
            Console.WriteLine(res2);
        }
        */

        #region Opgave 13
        private static void Opgave13(int[] lotteryNumbers)
        {
            //Opgave 13)
            Console.WriteLine(IsSorted(lotteryNumbers));
            Console.WriteLine(IsSorted(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(IsSorted(new List<string>() { "hej", "med", "dig" }));
            List<string> okSorteret = new List<string>() { "dig", "hej", "med" };
            Console.WriteLine(IsSorted(okSorteret));
        }

        public static bool IsSorted(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                //vi kan returnere allerede. 
                if (numbers[i - 1] > numbers[i])
                {
                    return false;
                }
            }
            //hvis vi kom hertil, så er array'et sorteret
            return true;
        }

        public static bool IsSorted(List<string> strings)
        {
            bool sorted = true;
            string cur, prev;
            for (int i = 1; i < strings.Count; i++)
            {
                cur = strings[i];
                prev = strings[i - 1];
                if (prev.CompareTo(cur) > 0)
                {
                    sorted = false;
                    //ingen grund til at fortsætte
                    break;
                }
            }
            return sorted;
        }
        #endregion

        #region Opgave 14
        private static void Opgave14()
        {
            //Opgave 14)
            Console.WriteLine(Sum(3, 5, 8));
            double[] treTal = { 3, 5, 8 };
            Console.WriteLine(Sum(treTal));
            Console.WriteLine(Sum(new double[] { 3, 5, 8 }));
        }

        public static double Sum(double x1, double x2)
        {
            return Sum(x1, x2, 0);
        }
        public static double Sum(double x1, double x2, double x3)
        {
            //OBS: Det er vigtigt at putte x1-x3 i et array
            //hvis vi kaldte Sum(x1, x2, x3) ville vi kalde os selv
            //og hurtigt få en StackOverflowException.
            return Sum(new double[] { x1, x2, x3 });
        }
        public static double Sum(params double[] numbers)
        {
            double sum = 0;
            foreach (double num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        #endregion

        #region Opgave 15
        private static void Opgave15()
        {
            /*
             * Den 'bedste', dvs. den mest SPECIFIKKE metode kaldes
             */
            Console.WriteLine(M(false)); //True
            Console.WriteLine(M(10));    //-10
            Console.WriteLine(M(3.0, 4)); //28
            Console.WriteLine(M(3, 4));   //14
            Console.WriteLine(M(3, 4.0)); //21
            Console.ReadLine();

            /* For at kalde M(byte, byte) skal vi lave et cast til byte */
            Console.WriteLine(M((byte)3, (byte)4));
        }

        public static double M(int i) { return -i; }
        public static bool M(bool b) { return !b; }
        public static double M(byte x, byte y) { return x + y; }
        public static double M(int x, int y) { return 2 * (x + y); }
        public static double M(int x, double y) { return 3 * (x + y); }
        public static double M(double x, double y) { return 4 * (x + y); }
        #endregion

        #region Opgave 16
        private static void Opgave16()
        {
            int b = 5;
            doStuff(b);
            Console.WriteLine(b); //5
            //doStuff(ref b);
            //Console.WriteLine(b); //10
            doStuff(out b);
            Console.WriteLine(b); //2
        }

        //Bemærk: Man kan ikke overloade metoder hvor forskellen kun ligger i ref eller out
        //Udkommenter derfor én ad gangen for at observere opførsel
        public static void doStuff(int a) { a *= 2; }
        //public static void doStuff(ref int a) { a *= 2; } 
        public static void doStuff(out int a) { a = 2; }
        #endregion
    }
}
