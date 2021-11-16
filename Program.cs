using System;

namespace text_based_adventure
{
    class Program
    {
        public static Player currentPlayer = new Player();
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Console.WriteLine("Du wachst gerade auf...");
            Console.WriteLine("Du liegst auf einem harten Steinboden und die Sonne scheint dir ins Gesicht");
            Console.WriteLine("Was tust du als erstes? (gib die gewünschte Nummer ein)");
            AnfangKapitel1.HandlungNachErwachen();
        }
    }
}
