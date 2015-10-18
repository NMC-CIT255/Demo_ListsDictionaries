using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ListsDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Player myPlayer = new Player("Bonzo");

            InitializePlayerWeapons(myPlayer);
            DisplayPlayersWeapons(myPlayer);


            Console.ReadLine();

        }

        public static void InitializePlayerWeapons(Player myPlayer)
        {
            myPlayer.Weapons.Add(
                new Weapon
                {
                    Type = Weapon.WeaponType.gun,
                    Name = "Thompson Submachine Gun",
                    Description = "Fast firing submachine gun with a 50 shell mag"
                });

            myPlayer.Weapons.Add(
                new Weapon
                {
                    Type = Weapon.WeaponType.knife,
                    Name = "Bowie Knife",
                    Description = "Really big knife"
                });
        }

        public static void DisplayPlayersWeapons(Player myPlayer)
        {
            Console.Clear();

            Console.WriteLine();

            Console.WriteLine("The Player has the following weapons:");
            Console.WriteLine();

            foreach (Weapon weapon in myPlayer.Weapons)
            {
                Console.WriteLine("Weapon Name: " + weapon.Name);
                Console.WriteLine("Weapon Type: " + weapon.Type);
                Console.WriteLine("Weapon Description: " + weapon.Description);
                Console.WriteLine("");
            }

        }
    }
}
