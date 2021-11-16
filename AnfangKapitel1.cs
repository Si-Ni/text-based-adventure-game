using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_based_adventure
{
    class AnfangKapitel1
    {
        public static void HandlungNachErwachen()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("============================================================");
            Console.WriteLine("1: schau dich um");
            Console.WriteLine("2: überprüfe deine Taschen");
            Console.WriteLine("3: Gesundheitszustand überprüfen");
            Console.WriteLine("4: stehe auf (fortfahren)");
            Console.WriteLine("============================================================");
            string userInput = Console.ReadLine();
            Console.Clear();
            if(userInput == "1")
            {
                UmschauenNachErwachen();
            }else if(userInput == "2")
            {
                TaschenPrüfen();
            }else if(userInput == "3")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Dir geht es soweit ganz gut. Außer ein paar Schürfwunden, kannst du keine ernsthaften Verletzungen");
                Console.WriteLine("an dir feststellen, also tief durchatmen und erstmal keine Panik (Gesundheitszustand: " + Program.currentPlayer.health + "%" + ")");
                Console.WriteLine("Du hast jedoch etwas Hunger (Nahrung: " + Program.currentPlayer.nahrung + "%) und Durst (Hydration: " + Program.currentPlayer.hydration + "%)");
                HandlungNachErwachen();
            }
            else if (userInput == "4")
            {
                AufstehenKapitel2.Aufstehen();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Du bist zu schwach, um das zu tun");
                HandlungNachErwachen();
            }
        }

        private static void UmschauenNachErwachen()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("Du schaust dich um");
            Console.WriteLine("Du befindest dich auf einem großen menschenleeren Platz inmitten einer rießigen Metropole.");
            Console.WriteLine("Du siehst überall nur verlassene Gebäude und Wolkenkratzer, egal wo du hinschaust.");
            Console.WriteLine("Das einzige was du hören kannst ist der Wind, welcher durch die leeren Gassen und Straßen pfeift.");
            Console.WriteLine("Es sieht so aus, als seist du vollkommen alleine und auf dich gestellt");
            HandlungNachErwachen();
        }

        private static void TaschenPrüfen()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Du findest in deinen Taschen folgende Gegenstände");
            Console.WriteLine("============================================================");
            for(int i = 1; i <= Program.currentPlayer.GetPlayerItems().Count; i++)
            {
                Console.WriteLine(i + ": " + Program.currentPlayer.GetPlayerItems().ElementAt(i-1));
            }
            Console.WriteLine("5: fortfahren");
            Console.WriteLine("============================================================");
            Console.WriteLine("Wähle einen Gegenstand aus, den du dir näher anschauen möchtest oder fahre fort");
            Console.WriteLine("------------------------------------------------------------");
            GegenstandAnschauen();
        }
        private static void GegenstandAnschauen()
        {
            string userInput = Console.ReadLine();
            if (userInput == "1")               //Brieftasche anschauen
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Du findest etwas Geld, aber was bringt dir das schon ohne eine vorhanden Gesellschaft,");
                Console.WriteLine("eine Kreditkarte mit der Aufschrift E-Star und einen Personalausweis.");
                Console.WriteLine("Auf dem Personalausweis steht ein Name, das wird vermutlich deiner sein,");
                Console.WriteLine("denn die Brieftasche war schließlich in deiner Hose");
                Console.WriteLine("Wie heißt du?...");
                userInput = Console.ReadLine();
                if (userInput != "" && userInput != " ")
                {
                    Program.currentPlayer.username = userInput;
                    Console.WriteLine("Ein angenehmes Gefühl den eigen Namen zu kennen, nicht wahr " + Program.currentPlayer.username + " ?");
                    Console.WriteLine("------------------------------------------------------------");
                    TaschenPrüfen();
                } else
                {
                    Console.WriteLine("Das glaube ich dir nicht, schau lieber nochmal genau nach.");
                }
            }
            else if (userInput == "2")          //Büroklammer anschauen
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Eine ganz normale Büroklammer, wer weiß wobei sie noch behilflich sein kann.");
                Console.WriteLine("------------------------------------------------------------");
                TaschenPrüfen();
            }
            else if (userInput == "3")          //Taschentücher anschauen
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Ein paar Taschentücher, warst du krank?");
                Console.WriteLine("Keine Sorge, die Taschentücher sind unbenutzt.");
                Console.WriteLine("------------------------------------------------------------");
                TaschenPrüfen();
            }
            else if (userInput == "4")          //Feuerzeug anschauen
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Ein ziemlich robustes Feuerzeug, noch fast voll, ");
                Console.WriteLine("aber zu sehr würde ich mich wahrscheinlich nicht darauf verlassen.");
                Console.WriteLine("------------------------------------------------------------");
                TaschenPrüfen();
            }
            else if (userInput == "5")          //fortfahren
            {
                Console.Clear();
                HandlungNachErwachen();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Du kannst dir nichts anschauen, was du nicht bei dir trägst");
                TaschenPrüfen();
            }
        }
    }
}
