﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lists_PlayerWeapons
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO 00a instantiate a player
            Player myPlayer = new Player("Bonzo");

            // TODO 03b call the method to demonstrate weapons list management
            DemoWeaponManagement(myPlayer);

        }

        // TODO 03a add a method to demonstrate weapons list management
        /// <summary>
        /// demonstrate listing, adding, and removing a weapon from the player's weapon list
        /// </summary>
        /// <param name="myPlayer">Player Object</param>
        public static void DemoWeaponManagement(Player myPlayer)
        {
            // TODO 04b call the method to initialize the player's weapons list
            InitializePlayerWeapons(myPlayer);

            // TODO 05b call the method to display the player's weapons list
            DisplayPlayersWeapons(myPlayer);

            // TODO 06b create a new weapon and add it to the player's weapons list
            // create and add a new laser weapon
            Console.WriteLine("We will now add a new weapon.");
            Console.WriteLine("Press the Enter key to continue.");
            Weapon laser = new Weapon
            {
                Type = Weapon.WeaponType.laser,
                Name = "Laser L04",
                Description = "Hand-held laser for melee type of fighting"
            };
            AddWeaponToPlayer(myPlayer, laser);
            Console.ReadLine();

            // TODO 06c display the player's weapons list
            DisplayPlayersWeapons(myPlayer);

            // TODO 07b choose and remove a weapon to the player's weapons list
            // remove a weapon
            Console.WriteLine("We will now remove a weapon.");
            RemoveWeaponFromPlayer(myPlayer, "Laser L04");
            Console.ReadLine();

            // TODO 07c display the player's weapons list
            DisplayPlayersWeapons(myPlayer);

            Console.WriteLine("Press the Enter key to continue.");
            Console.ReadLine();
        }


        // TODO 04a add a method to initialize the player's weapons list
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

        // TODO 05a add a method to display the player's weapons list
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

        // TODO 06a add a method to add a weapon to the player's weapons list
        /// <summary>
        /// add a weapon the player's weapon list
        /// </summary>
        /// <param name="myPlayer"></param>
        /// <param name="weapon"></param>
        public static void AddWeaponToPlayer(Player myPlayer, Weapon weapon)
        {
            myPlayer.Weapons.Add(weapon);
        }

        // TODO 07a add a method to remove a weapon to the player's weapons list
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
            //foreach (var weapon in myPlayer.Weapons)
            //{
            //    if (weapon.Name == weaponName)
            //    {
            //        weaponIndex = myPlayer.Weapons.IndexOf(weapon);
            //    }
            //}

            // use lambda operator
            weaponIndex = myPlayer.Weapons.FindIndex(c => c.Name == weaponName);

            Console.WriteLine("Remove the weapon with index = " + weaponIndex);
            Console.WriteLine("Press the Enter key to continue.");

            myPlayer.Weapons.RemoveAt(weaponIndex);
        }
    }
}
