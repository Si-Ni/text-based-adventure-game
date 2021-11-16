using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_based_adventure
{
    class Player
    {
        public string username = "unbekannt";
        public int health = 80;
        public int strength = 5;
        public int nahrung = 60;
        public int hydration = 50;
        List<string> items = new List<string> { "Brieftasche", "Büroklammer", "Taschentücher", "Feuerzeug" };

        public List<string> GetPlayerItems()
        {
            return this.items;
        }

        public Boolean IsPlayerDead()
        {
            if(this.health <= 0 || this.nahrung <= 0 || this.hydration <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public String GetPlayerStats()
        {
            return ($"Leben: {this.health}/100, Stärke: {this.strength}/100, Nahrung: {this.nahrung}/100, Hydration: {this.hydration}/100");
        }

        public void AddFood(int addedFood)
        {
            this.nahrung += addedFood;
            if(this.nahrung > 100)
            {
                this.nahrung = 100;
            }
        }
        public void AddDrink(int addedDrink)
        {
            this.hydration += addedDrink;
            if (this.hydration > 100)
            {
                this.hydration = 100;
            }
        }
        public void Heal(int healWert)
        {
            this.health += healWert;
            if (this.health > 100)
            {
                this.health = 100;
            }
        }
        public void AddItem(string item)
        {
            this.items.Add(item);
        }
    }
}
