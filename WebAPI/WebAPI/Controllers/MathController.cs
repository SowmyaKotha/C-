using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class MathController : ApiController
    {
        [HttpGet]
        public string State(string SignalX, string stateX)
        {
            string a="";
            if (stateX == "Y=1" && SignalX == "1")
            {

                a = "Y=1";
            }
            else
            {
                if (stateX == "Y=1" && SignalX == "0")
                {
                    a = "Y=0";
                }


                else
                {
                    if (stateX == "Y=0" && SignalX == "1")
                    {

                        a = "Y=1";
                    }
                    else
                    {
                        if (stateX == "Y=0" && SignalX == "0")
                        {
                            a = "Y=0";
                        }
                        
                    }
                }
            }

            return a;

        }

       

        [HttpGet]
        public string Get()
        {
            return "default";
        }
    }
    class Controller
    {
        private string stateOfX;
        private string stateOfY;
        private char SignalX;
        private bool finalState = false;

        public Controller()
        {
            goStateX();

            //goStateQ();



        }

        override public string ToString()
        {

            return "state of X = " + stateOfX + "  state of Y = " + stateOfY;


        }

        /// 

        /// State entry routines
        /// 

        private void goStateX()
        {
            stateOfX = "X=1";
            Console.WriteLine("Entering \n" + stateOfX);

        }

        private void goStateY1()
        {
            stateOfY = "1";
            Console.WriteLine("Entering 'Y'" + stateOfY);


        }
        private void goStateY0()
        {
            stateOfY = "0";
            Console.WriteLine("Entering 'Y'\n" + stateOfY);
            // return stateOfX;
        }
        private void goStateFinal()
        {
            finalState = true;
        }

        public void eventA()
        {
            // goStateY0();
            if (stateOfX == "X=1")
            {
                Console.WriteLine("Please Enter the initial state");
                stateOfY = Console.ReadLine();
                if (stateOfY == "0")
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
                        // Console.ReadLine();
                    }

                }
                else
                {
                    //if (stateOfU == "X")
                    // {
                    //Console.WriteLine("Please Enter the initial state");
                    // stateOfX = Console.ReadLine();
                    if (stateOfY == "1")
                    {
                        Console.WriteLine("Please Enter the SignalX value");
                        SignalX = Convert.ToChar(Console.ReadLine());
                        if (SignalX == '0')
                        {
                            goStateY0();
                            Console.WriteLine("In 'Y'=0 with SignalX =0");
                            //Console.ReadLine();
                        }
                        else
                        {
                            //Console.WriteLine("Please Enter the SignalX value");
                            if (SignalX == '1')
                            {
                                goStateY1();
                                Console.WriteLine("In 'Y'=1\n with SignalX=1");
                                //Console.ReadLine();
                            }
                        }
                    }
                    //  }
                    //goStateP();
                    //goStateQ();


                }
            }

        }




        public void eventF()
        {
            if (stateOfX == "X=1")
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
