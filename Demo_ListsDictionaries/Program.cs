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

            // create and add a new laser weapon
            Console.WriteLine("We will now add a new weapon.");
            Weapon laser = new Weapon
                {
                    Type = Weapon.WeaponType.laser,
                    Name = "Laser L04",
                    Description = "Handheld laser for malay type of fighting"
                };
            AddWeaponToPlayer(myPlayer, laser);
            Console.ReadLine();

            DisplayPlayersWeapons(myPlayer);

            // remove a weapon
            Console.WriteLine("We will now remove a weapon.");
            RemoveWeaponFromPlayer(myPlayer, "Bowie Knife");
            Console.ReadLine();

            DisplayPlayersWeapons(myPlayer);

            Console.ReadLine();

        }
        /// <summary>
        /// add weapons to the players list of weapons
        /// </summary>
        /// <param name="myPlayer">Player Object</param>
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

        /// <summary>
        /// display all of the player's weapons in the player's list of weapons
        /// </summary>
        /// <param name="myPlayer">Player Object</param>
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

            Console.ReadLine();
        }

        /// <summary>
        /// add a weapon the the player's weapon list
        /// </summary>
        /// <param name="myPlayer"></param>
        /// <param name="weapon"></param>
        public static void AddWeaponToPlayer(Player myPlayer, Weapon weapon)
        {
            myPlayer.Weapons.Add(weapon);
        }


        /// <summary>
        /// remove a weapon from the player's weapon list
        /// </summary>
        /// <param name="myPlayer">Player Object</param>
        /// <param name="weaponName">weapon to remove</param>
        public static void RemoveWeaponFromPlayer(Player myPlayer, string weaponName)
        {
            // set default value to -1 to indicate that the weapon was not found in the list
            int weaponIndex = -1;

            // cycle through the weapon list until the weapon name matches and get the index of the weapon
            foreach (var weapon in myPlayer.Weapons)
            {
                if (weapon.Name == weaponName)
                {
                    weaponIndex = myPlayer.Weapons.IndexOf(weapon);
                }
            }

            // use lambda operator
            // weaponIndex = myPlayer.Weapons.FindIndex(c => c.Name == weaponName);

            Console.WriteLine("Remove the weapon with indesx = " + weaponIndex);

            myPlayer.Weapons.RemoveAt(weaponIndex);
        }
    }
}
