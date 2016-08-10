using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ref akka
using Akka;
using Akka.Actor;
    

namespace getting_started_akka_console_app
{
    //create an(immutable) message type that your actor will respond to
    public class Greet
    {
        public string Who { get; set; }

        public Greet(string who)
        {
            who = who;
        }
    }


    //create the actor class
    public class GrettingActor : ReceiveActor
    {
        public GrettingActor()
        {
            //tell the actor to respond 
            //to the Greet message
            Receive<Greet>(greet => Console.WriteLine("Hello {0}", greet.Who));
        }
    }


    class Program
    {
        //http://getakka.net/docs/Getting%20started
        static void Main(string[] args)
        {
            //create a new actor system(a container for your actor)
            var system = ActorSystem.Create("MySistem");

            //create your actor and get a reference to it.
            //this will be an "ActorRef", which is not a reference
            //to the actual actor instance but rathe a client or proxy to it
            var greeter = system.ActorOf<GrettingActor>("greeter");

            //send a message to the actor
            greeter.Tell(new Greet("World"));

            //This prevent the app from existing before the async work is done
            Console.ReadLine();

        }
    }
}
