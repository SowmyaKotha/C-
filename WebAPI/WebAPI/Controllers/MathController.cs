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
        public string State(string SignalX, string initialstateX, string initialstateY)
        {
            string nextstateY="";
            if (initialstateX == "1")
            {
                if (initialstateY == "0" && SignalX == "0")
                {
                    nextstateY = "You are in the same state!";
                }
                else
                {
                    if (initialstateY == "0" && SignalX == "1")
                    {
                        nextstateY = "You are in Y=1 state";
                    }

                    else
                    {
                        if (initialstateY == "1" && SignalX == "1")
                        {
                            nextstateY = "You are in same state";
                        }
                        else
                        {
                            if(initialstateY=="1"&& SignalX == "0")
                            {
                                nextstateY = "You are in Y=0 state";
                            }
                        }
                    }
                }

            }
            else
            {
                nextstateY = "Sorry! You are in wrong state to make transition";
            }
           



            return nextstateY;

        }

       

        [HttpGet]
        public string Get()
        {
            return "default";
        }
    }
    //class Controller
    //{
    //    private string initialstateX;
    //    private string initialstateY;
    //    private char SignalX;
    //    private bool finalState = false;

    //    public Controller()
    //    {
    //        eventA();
    //        // goStateX();

    //        //goStateQ();
    //        //initialize



    //    }

    //    override public string ToString()
    //    {

    //        return "state of X = " + stateOfX + "  state of Y = " + stateOfY;


    //    }

    //    /// 

    //    /// State entry routines
    //    /// 

    //    private void goStateX()
    //    {
    //        stateOfX = "X=1";
    //        Console.WriteLine("Entering \n" + stateOfX);

    //    }

    //    private void goStateY1()
    //    {
    //        stateOfY = "1";
    //        Console.WriteLine("Entering 'Y'" + stateOfY);


    //    }
    //    private void goStateY0()
    //    {
    //        stateOfY = "0";
    //        Console.WriteLine("Entering 'Y'\n" + stateOfY);
    //        // return stateOfX;
    //    }
    //    private void goStateFinal()
    //    {
    //        finalState = true;
    //    }

    //    public string eventA()
    //    {
    //        // goStateY0();
    //        if (stateOfX == "X=1")
    //        {
    //            Console.WriteLine("Please Enter the initial state of Y");
    //            stateOfY = Console.ReadLine();
    //            if (stateOfY == "0")
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
    //                    // Console.ReadLine();
    //                }

    //            }
    //            else
    //            {
    //                //if (stateOfU == "X")
    //                // {
    //                //Console.WriteLine("Please Enter the initial state");
    //                // stateOfX = Console.ReadLine();
    //                if (stateOfY == "1")
    //                {
    //                    Console.WriteLine("Please Enter the SignalX value");
    //                    SignalX = Convert.ToChar(Console.ReadLine());
    //                    if (SignalX == '0')
    //                    {
    //                        goStateY0();
    //                        Console.WriteLine("In 'Y'=0 with SignalX =0");
    //                        //Console.ReadLine();
    //                    }
    //                    else
    //                    {
    //                        //Console.WriteLine("Please Enter the SignalX value");
    //                        if (SignalX == '1')
    //                        {
    //                            goStateY1();
    //                            Console.WriteLine("In 'Y'=1\n with SignalX=1");
    //                            //Console.ReadLine();
    //                        }
    //                    }
    //                }
    //                //  }
    //                //goStateP();
    //                //goStateQ();


    //            }
    //        }
    //        return stateOfY;
    //    }




    //    public void eventF()
    //    {
    //        if (stateOfX == "X=1")
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
