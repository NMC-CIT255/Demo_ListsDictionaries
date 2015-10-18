using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ListsDictionaries
{
    /// <summary>
    /// Player class, inherites from Character class
    /// </summary>
    public class Player : Character
    {
        #region ENUMERABLES


        #endregion

        #region FIELDS

        private List<CoinGroup> _coins; // TODO Sprint 3 Mod 07a - add a field/property to hold the player's coins
        private List<Weapon> _weapons; // TODO Sprint 3 Mod 21 - add a field/property to hold the player's weapons      

        #endregion

        #region PROPERTIES
        
        public List<CoinGroup> Coins
        {
            get { return _coins; }
            set { _coins = value; }
        }

        public List<Weapon> Weapons
        {
            get { return _weapons; }
            set { _weapons = value; }
        }

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// instantiate a player and set intial properties
        /// </summary>
        /// <param name="name">player name</param>
        /// <param name="gender">player gender</param>
        /// <param name="race">player race</param>
        /// <param name="currentRoomNumber">room location as an index of the hall array</param>
        public Player(
            string name)
            : base(name)
        {

            // TODO Sprint 3 Mod 07b - instantiate the player's coin group list
            _coins = new List<CoinGroup>();

            // TODO Sprint 3 Mod 22 - instantiate the player's weapons list
            _weapons = new List<Weapon>();
        }

        #endregion

        #region METHODS



        #endregion
    }
}
