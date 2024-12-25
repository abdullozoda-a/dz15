using System;

namespace ConsoleApp8
{

        class Appliance
        {
            private string Brand;
            protected int Power;
            public bool Ison;

            public string getBrand
            {
                get { return Brand; }
                set { Brand = value; }
            }

            public int getPower
            {
                get { return Power; }
                set { Power = value; }
            
            }

            public void TurnOff()
            {
                Ison = false;
                Console.WriteLine($"{Brand} is turned off");
            
            }

            public void TurnOn()
            {
                Ison = true;
                Console.WriteLine($"{Brand} is turned on");
            }
        }

        class moshina : Appliance
        {
            public moshina()
            {
                getBrand = "mac book";
                getPower = 93766;
                Ison = false;
            }

            public moshina(string brand, int power)
            {
                getBrand = brand;
                getPower = power;
                Ison = false;
            }
        }

        class xalados : Appliance
        {
            public xalados()
            {
                getBrand = "apple";
                getPower = 80990;
                Ison = false;
            }

            public xalados(string brand, int power)
            {
                getBrand = brand;
                getPower = power;
                Ison = false;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                moshina moshina1= new moshina();
                moshina moshina2 = new moshina("mac",09853);
                xalados xalados1 = new xalados();
                xalados xalados2 = new xalados("apple", 98847);
                Console.WriteLine(moshina1.getBrand);
                Console.WriteLine(moshina1.getPower);
                Console.WriteLine(moshina2.getBrand);
                Console.WriteLine(moshina2.getPower);
                Console.WriteLine(xalados1.getBrand);
                Console.WriteLine(xalados1.getPower);
                Console.WriteLine(xalados2.getBrand);
                Console.WriteLine(xalados2.getPower);
                
            }
        }
    }

