using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Lists_PlayerWeapons
{
    /// <summary>
    /// Player class, inherites from Character class
    /// </summary>
    public class Player : Character
    {
        #region ENUMERABLES


        #endregion

        #region FIELDS

        private List<Weapon> _weapons; // add a field/property to hold the player's weapons      

        #endregion

        #region PROPERTIES
        
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
        public Player(
            string name)
            : base(name)
        {

            _weapons = new List<Weapon>();
        }

        #endregion

        #region METHODS



        #endregion
    }
}
