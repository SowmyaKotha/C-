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
        public string Add(string SignalX, string stateX)
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
    //class Controller
    //{
    //    private string stateOfU;
    //    private string stateOfX;
    //    private char SignalX;
    //    private bool finalState = false;

    //    public Controller()
    //    {
    //        goStateX();
    //        // eventA();
    //        //goStateQ();



    //    }

    //    override public string ToString()
    //    {

    //        return "state of U = " + stateOfU + "  state of X = " + stateOfX;


    //    }

    //    /// 

    //    /// State entry routines
    //    /// 

    //    private void goStateX()
    //    {
    //        stateOfU = "X";
    //        Console.WriteLine("Entering 'X'=1\n");

    //    }

    //    private void goStateY1()
    //    {
    //        stateOfX = "Y=1";
    //        Console.WriteLine("Entering 'Y'=1\n");


    //    }
    //    private void goStateY0()
    //    {
    //        stateOfX = "Y=0";
    //        Console.WriteLine("Entering 'Y'=0\n");
    //    }
    //    private void goStateFinal()
    //    {
    //        finalState = true;
    //    }

    //    public void eventA()
    //    {
    //        // goStateY0();
    //        if (stateOfU == "X")
    //        {
    //            Console.WriteLine("Please Enter the initial state");
    //            stateOfX = Console.ReadLine();
    //            if (stateOfX == "Y=0")
    //            {
    //                Console.WriteLine("Please Enter the SignalX value");
    //                SignalX = Convert.ToChar(Console.ReadLine());
    //                if (SignalX == '0')
    //                {
    //                    goStateY0();
    //                    Console.WriteLine("In 'Y'=0");
    //                    Console.WriteLine("In 'Y with SignalX =0");
    //                }
    //                else
    //                {
    //                    //Console.WriteLine("Please Enter the SignalX value");
    //                    if (SignalX == '1')
    //                    {

    //                        goStateY1();
    //                        Console.WriteLine("In 'Y'=1\n with SignalX=1");
    //                    }
    //                }
    //            }
    //            else
    //            {
    //                if (stateOfU == "X")
    //                {
    //                    Console.WriteLine("Please Enter the initial state");
    //                    stateOfX = Console.ReadLine();
    //                    if (stateOfX == "Y=1")
    //                    {
    //                        Console.WriteLine("Please Enter the SignalX value");
    //                        SignalX = Convert.ToChar(Console.ReadLine());
    //                        if (SignalX == '0')
    //                        {
    //                            goStateY0();
    //                            Console.WriteLine("In 'Y'=0 with SignalX =0");
    //                        }
    //                        else
    //                        {
    //                            // Console.WriteLine("Please Enter the SignalX value");
    //                            if (SignalX == '1')
    //                            {
    //                                goStateY1();
    //                                Console.WriteLine("In 'Y'=1\n with SignalX=1");
    //                            }
    //                        }
    //                    }
    //                }
    //                //goStateP();
    //                //goStateQ();


    //            }
    //        }
    //    }




    //    public void eventF()
    //    {
    //        if (stateOfU == "X")
    //        {
    //            goStateFinal();
    //        }
    //        else
    //        {
    //            Console.WriteLine("Event F ignored");
    //        }
    //    }
    //    public bool IsFinalState()
    //    {
    //        return finalState;
    //    }
    //}
}
