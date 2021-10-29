using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            math math1 = new math();
            Console.WriteLine(math1.pow(2, 4));


        }

    }


    class math
    {

        public int pow(int num, byte power)
        {
            int total = 1;
            for (int i = 0; i < power; i++)
            {
                total = total * num;
            }
            return total;
        }
        public double pow(double num, double power)
        {
            double total = 1;
            for (int i = 0; i < power; i++)
            {
                total = total * num;
            }
            return total;
        }
        public int kok(int num, int power)
        {
            int total = 1;
            for (int i = 0; i < power; i++)
            {
                total = total / num;
            }
            return total;
        }
    }
}

//tamamile 1 ci task
using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            #region task 1
            {


                home home1 = new home();
                home1.otaq = 3;
                home1.mertebe = 5;
                home1.unvan = "sabit rehman";
                home1.telefon = "0554034430";
                home1.seher = "baki";

                home home2 = new home();
                home2.otaq = 5;
                home2.mertebe = 2;
                home2.unvan = "sabit rehman";
                home2.telefon = "0559034430";
                home2.seher = "seki";

                Console.WriteLine(home1.homes());

                home home3 = new home();
                home3.otaq = 9;
                home3.mertebe = 7;
                home3.unvan = "sabit rehman";
                home3.telefon = "0559035330";
                home3.seher = "seki";



            }

        }

        class home
        {
            public byte otaq;
            public int mertebe;
            public string unvan;
            public string telefon;
            public string seher;

            public string homes()
            {
                return ($" Unvan budur { unvan}  telefon nomresi { telefon}  yasadigi seher { seher} ");
            }


            #endregion






        }
          }
    }   
