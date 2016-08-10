using System;
using Akka.Actor;

namespace getting_started_akka_console_app
{
    public class GrettingActor : ReceiveActor
    {
        //create the actor class
        public GrettingActor()
        {
            //tell the actor to respond 
            //to the Greet message
            Receive<Greet>(greet => Console.WriteLine("Hello {0}", greet.Who));
        }
    }
}