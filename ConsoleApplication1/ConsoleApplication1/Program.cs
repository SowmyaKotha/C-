using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller ctrl = new Controller();
            while (!ctrl.IsFinalState())
            {
                Console.WriteLine("Please enter an event");
                string line = Console.ReadLine();
                switch (line[0])
                {
                    case 'A':
                        
                        ctrl.eventA(); break;
                    case 'B': ctrl.eventB(); break;
                    
                    case 'F': ctrl.eventF(); break;
                    default:
                        Console.WriteLine("Input not an event: " + line);
                        break;
                }
                Console.WriteLine("STATUS: " + ctrl.ToString());
            }
        }
    }
    class Controller
    {
        private string stateOfU = "";
        private string stateOfX = "";
        private char SignalX;
        private bool finalState = false;

        public Controller()
        {
            goStateX();
            //goStateQ();
           // Console.WriteLine("Please enter an event");


        }

        override public string ToString()
        {

            return "state of U = " + stateOfU + "  state of X = " + stateOfX;

        }

        /// 

        /// State entry routines
        /// 

        private void goStateX()
        {
            stateOfU = "X";
            Console.WriteLine("Entering 'X'=1\n");

        }

        private void goStateY1()
        {
            stateOfX = "Y=1";
            Console.WriteLine("Entering 'Y'=1\n");


        }
        private void goStateY0()
        {
            stateOfX = "Y=0";
            Console.WriteLine("Entering 'Y'=0\n");
        }
        private void goStateFinal()
        {
            finalState = true;
        }

        public void eventA()
        {
            goStateY0();
            if (stateOfU == "X" && stateOfX == "Y=0")
            {
                Console.WriteLine("Please Enter the SignalX value");
                SignalX = Convert.ToChar(Console.ReadLine());
                if (SignalX == '0')
                {
                    goStateY0();
                    Console.WriteLine("In 'Y'=0");
                    Console.WriteLine("In 'Y with SignalX =0");
                }
                else
                {
                    //Console.WriteLine("Please Enter the SignalX value");
                    if (SignalX == '1')
                    {

                        goStateY1();
                        Console.WriteLine("In 'Y'=1\n with SignalX=1");
                    }
                }
                //goStateP();
                //goStateQ();

            }

        }
        public void eventB()
        {
            goStateY1();
            if (stateOfU == "X" && stateOfX == "Y=1")
            {
                Console.WriteLine("Please Enter the SignalX value");
                SignalX = Convert.ToChar(Console.ReadLine());
                if (SignalX == '0')
                {
                    goStateY0();
                    Console.WriteLine("In 'Y'=0 with SignalX =0");
                }
                else
                {
                    // Console.WriteLine("Please Enter the SignalX value");
                    if (SignalX == '1')
                    {
                        goStateY1();
                        Console.WriteLine("In 'Y'=1\n with SignalX=1");
                    }
                }
            }

        }

        public void eventF()
        {
            if (stateOfU == "X")
            {
                goStateFinal();
            }
            else
            {
                Console.WriteLine("Event F ignored");
            }
        }
        public bool IsFinalState()
        {
            return finalState;
        }
    }
}


