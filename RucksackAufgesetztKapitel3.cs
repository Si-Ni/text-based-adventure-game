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
        }
    }
}
