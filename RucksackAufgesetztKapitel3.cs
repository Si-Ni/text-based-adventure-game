using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_based_adventure
{
    class RucksackAufgesetztKapitel3
    {
        public static void RucksackAufsetzen()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.WriteLine("Du trägst folgende Gegenstände bei dir...");
            Console.WriteLine("============================================================");
            for (int i = 1; i <= Program.currentPlayer.GetPlayerItems().Count; i++)
            {
                Console.WriteLine(i + ": " + Program.currentPlayer.GetPlayerItems().ElementAt(i - 1));
            }
            Console.WriteLine("============================================================");
            Console.WriteLine("Dein Gesundheitszustand");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine(Program.currentPlayer.GetPlayerStats());
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Beim Aufheben des Rucksacks hast du bemerkt, dass eine Tür des Gebäudes offen steht...");
            Console.WriteLine("Da du auf der Suche nach anderen Menschen und vor allem Informationen bist,");
            Console.WriteLine("entscheidest du dich dazu, das Gebäude zu betreten.");
            Console.WriteLine("Nachdem du durch die Tür gegangen bist, fällt sie hinter dir zu...");
            Console.WriteLine("Da hättest du wohl mal besser aufgepasst, denn jetzt ist sie verschlossen.");
            Console.WriteLine("In dem Raum, in welchem du dich befindest, ist es stockdunkel.");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Was tust du?");
            Console.WriteLine("============================================================");
            Console.WriteLine("1: Du nimmst dein Feuerzeug, um etwas Licht zu haben (verbraucht etwas Feuerzeugbenzin)");
            Console.WriteLine("2: Du verlässt dich auf deine anderen Sinne und versuchst ohne Licht voranzukommen (gefährlich)");
            Console.WriteLine("============================================================");
            string userInput = Console.ReadLine();
            Console.Clear();
            if (userInput == "1")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Du holst dein Feuerzeug heraus und machst es an...");
                Console.WriteLine("Dadurch kannst du wenigstens ein bisschen was sehen und erkennen, ");
                Console.WriteLine("was sich direkt vor deinen Füßen befindet.");
                Console.WriteLine("Du läufst weiter in den Raum hinein, aber wonach suchst du eigentlich?");
                Console.WriteLine("Als du weiterläufst, bemerkst du einen Stuhl, der vor dir auf dem Boden liegt.");
                Console.WriteLine("Gut, dass du dein Feuerzeug angemacht hast, ohne das Licht hättest du ihn bestimmt");
                Console.WriteLine("nicht gesehen und dich eventuell verletzt. Als du am anderen Ende des Raumes ankommst,");
                Console.WriteLine("findest du einen Lichtschalter, welcher zu deiner Verwunderung funktioniert.");
                Program.currentPlayer.items[Program.currentPlayer.items.IndexOf("Feuerzeug")] = "Feuerzeug (80%)";
                Console.ReadKey();
                RaumErleuchtetKapitel4.RaumErleuchtetDokumentFinden();
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Du bist also sehr mutig oder vielleicht trifft es leichtsinnig besser?");
                Console.WriteLine("Du läufst weiter in den Raum hinein, aber kannst nichts sehen außer absolute Dunkelheit.");
                Console.WriteLine("Plötzlich stolperst du über irgendetwas, was auf dem Boden liegt.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Gib eine '1' oder eine '2' ein und lass den Zufall über den weiteren Verlauf entscheiden...");
                userInput = Console.ReadLine();
                Random random = new();
                int randomNumber = random.Next(1, 3);
                if(userInput == randomNumber.ToString())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nochmal Glück gehabt, nichts passiert...  Das hätte auch anders ausgehen können.");
                    Console.WriteLine("Bei deinem Sturz bist du jedoch gegen einen Lichtschalter an der Wand gekommen,");
                    Console.WriteLine("welcher zu deiner Verwunderung sogar noch funktioniert.");
                    Console.ReadKey();
                    RaumErleuchtetKapitel4.RaumErleuchtetDokumentFinden();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du kannst dich nicht mehr fangen und knallst mit deinem Kopf gegen eine Wand...");
                    Console.WriteLine("Aua, das tat weh und du scheinst dich etwas verletzt zu haben (-15 Leben)");
                    Program.currentPlayer.health -= 15;
                    Console.WriteLine("Du solltest ab jetzt vielleicht etwas vorsichtiger sein.");
                    Console.WriteLine("Bei deinem Sturz hattest du jedoch auch etwas Glück, denn du bist dabei gegen einen");
                    Console.WriteLine("Lichtschalter gekommen, welcher zu deiner Verwunderung sogar noch funktioniert.");
                    Console.ReadKey();
                    RaumErleuchtetKapitel4.RaumErleuchtetDokumentFinden();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Das kannst du gerade nicht tun");
                RucksackAufsetzen();
            }
        }
    }
}
