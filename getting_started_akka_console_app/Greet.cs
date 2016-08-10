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
}