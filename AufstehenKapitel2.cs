using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_based_adventure
{
    class AufstehenKapitel2
    {
        public static void Aufstehen()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Du stehst langsam auf, dein Kopf tut etwas weh und");
            Console.WriteLine("dir wird ein bisschen schwindelig dabei. Es ist sehr hell, ");
            Console.WriteLine("du hast vermutlich genau die Mittagssonne erwischt, um aufzuwachen.");
            Console.WriteLine("Da du so sehr geblendet wirst, kannst du nur wenig sehen, du entdeckst jedoch in ein paar");
            Console.WriteLine("hundert Meter weiter einen roten Rucksack, der an einer Hauswand lehnt und entscheidest dich,");
            Console.WriteLine("dort hinzulaufen...");
            Console.WriteLine("Wie schnell möchtest du zum Rucksack laufen?");
            Console.WriteLine("============================================================");
            Console.WriteLine("1: gehen (Nahrung: -1, Hydration: -1)");
            Console.WriteLine("2: rennen (Stärke: +1, Nahrung: -2, Hydration: -2)");
            Console.WriteLine("============================================================");
            string userInput = Console.ReadLine();
            Console.Clear();
            if (userInput == "1")
            {
                Program.currentPlayer.hydration--;
                Program.currentPlayer.nahrung--;
            }
            else if (userInput == "2")
            {
                Program.currentPlayer.hydration -= 2;
                Program.currentPlayer.nahrung -= 2;
                Program.currentPlayer.strength++;
            }
            else
            {
                Console.WriteLine("So kommst du dort nicht hin.");
            }
            Console.WriteLine("Du bist an dem Rucksack angekommen, was möchtest du tun?");
            AktionAmRucksack();
        }

        private static void AktionAmRucksack()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("============================================================");
            Console.WriteLine("1: überprüfe deinen Gesundheitszustand");
            Console.WriteLine("2: öffne den Rucksack und schaue nach, was sich darin befindet");
            Console.WriteLine("3: fortfahren");
            Console.WriteLine("============================================================");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(Program.currentPlayer.GetPlayerStats());
                AktionAmRucksack();
            }
            else if (userInput == "2")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Du öffnest vorsichtig den Rucksack...");
                Console.WriteLine("Darin findest du eine Wasserflasche, ein paar Proteinriegel und ein Taschenmesser");
                Console.ReadKey();
                EssenUndTrinken();
            }
            else if (userInput == "3")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Du setzt den Rucksack auf...");
                Program.currentPlayer.AddItem("Wasserflasche (+40)");
                Program.currentPlayer.AddItem("Proteinriegel (+30)");
                Program.currentPlayer.AddItem("Taschenmesser");
                RucksackAufgesetztKapitel3.RucksackAufsetzen();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Das geht leider nicht");
                AktionAmRucksack();
            }
        }

        private static void EssenUndTrinken()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Was möchtest du mit der gefundenen Nahrung machen?");
            Console.WriteLine("============================================================");
            Console.WriteLine("1: etwas essen und trinken (Hydration: +40, Nahrung: +30, Leben: +10)");
            Console.WriteLine("2: nur etwas essen (Nahrung: +30, Leben: +5)");
            Console.WriteLine("3: nur etwas trinken (Hydration: +40, Leben: +5)");
            Console.WriteLine("4: beides vorerst wieder einstecken und aufbewahren");
            Console.WriteLine("5: überprüfe deinen Gesundheitszustand");
            Console.WriteLine("============================================================");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Program.currentPlayer.AddDrink(40);
                Program.currentPlayer.AddFood(30);
                Program.currentPlayer.Heal(10);
            }
            else if (userInput == "2")
            {
                Program.currentPlayer.AddFood(30);
                Program.currentPlayer.Heal(5);
                Program.currentPlayer.AddItem("Wasserflasche (+40)");
            }
            else if (userInput == "3")
            {
                Program.currentPlayer.AddDrink(40);
                Program.currentPlayer.Heal(5);
                Program.currentPlayer.AddItem("Proteinriegel (+30)");
            }
            else if (userInput == "4")
            {
                Program.currentPlayer.AddItem("Wasserflasche (+40)");
                Program.currentPlayer.AddItem("Proteinriegel (+30)");
            }
            else if (userInput == "5")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(Program.currentPlayer.GetPlayerStats());
                EssenUndTrinken();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Das kannst du jetzt nicht tun");
                EssenUndTrinken();
            }
            Program.currentPlayer.AddItem("Taschenmesser");
            RucksackAufgesetztKapitel3.RucksackAufsetzen();
        }
    }
}
