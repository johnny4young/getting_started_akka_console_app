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
