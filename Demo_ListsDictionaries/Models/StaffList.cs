﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Demo_ListsDictionaries.Controllers;

namespace Demo_ListsDictionaries
{
    /// <summary>
    /// class to manage an array of staff
    /// </summary>
    public class StaffList
    {
        #region ENUMERABLES

        #endregion

        #region FIELDS

        public const int MAX_NUMBER_OF_STAFF = ControllerSettings.MAX_NUMBER_OF_STAFF;

        private Staff[] _staff;


        #endregion

        #region PROPERTIES
        public Staff[] Staff
        {
            get { return _staff; }
            set { _staff = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public StaffList()
        {
            _staff = new Staff[MAX_NUMBER_OF_STAFF];
        }

        #endregion

        #region METHODS


        #endregion
    }
}
