using System;

namespace ConsoleApp8
{  
    using System;
    class Program
    {
        private string model;
        protected int power;
        public bool OnOff;

        public string Brand
        {
            get { return model; }
            set { model = value; }
        }

        public void ON()
        {
            OnOff = true;
            Console.WriteLine("Turned ON");
        }

        public void OFF()
        {
            OnOff = false;
            Console.WriteLine("Turned OFF");
        }

        public void Info()
        {
            Console.WriteLine("Brand: " + model);
            Console.WriteLine("Power: " + power);
            Console.WriteLine("On off: " + OnOff);
        
    }

        class Refrigirator : Program
        {
            public Refrigirator(string MODEL, int power)
            {
                this.model = MODEL;
                this.power = power;
                this.OnOff = false;
            }
        }

        public void RefrigiratorDisplay()
        {
            Console.WriteLine("InfoRefrigirator");
            
        }

        class WashingMachine: Program
        {
            public WashingMachine(string MODEL, int power)
            {
                this.model = MODEL;
                this.power = power;
                this.OnOff = false;
            }

            public void InfoWashingMachineDisplay()
            {
                Console.WriteLine("InfoWashingMachine");
            }
        }
        static void Main(string[] args)
        {
           Refrigirator refrigirator = new Refrigirator("LG", 220);
           WashingMachine washingMachine = new WashingMachine("FUL HD", 110);
           
           refrigirator.RefrigiratorDisplay();
           refrigirator.ON();
           refrigirator.OFF();
           
           Console.WriteLine(refrigirator.model);
           
           
           washingMachine.InfoWashingMachineDisplay();
           washingMachine.OnOff = true;
           washingMachine.Info();
           washingMachine.OnOff = false;
           washingMachine.InfoWashingMachineDisplay();
           
           
        }
    }
}
