﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame
{
    /// <summary>
    /// base class for the player and all game characters
    /// </summary>
    public class Character
    {
        #region ENUMERABLES

        public enum GenderType
        {
            OTHER,
            MALE,
            FEMALE
        }

        public enum WeaponType
        {
            FISTS,
            CUTLASS,
            AXE,
            PIKE,
            PISTOL,
            MUSKET,
            DYNAMITE
        }
        #endregion

        #region FIELDS

        private string _name;
        private int _coin;
        private bool _personlity;
        private WeaponType  _weapon;
        private GenderType _gender;
        private int _islandLocationId;

        #endregion

        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Coin
        {
            get { return _coin; }
            set { _coin = value; }
        }

        public GenderType Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public bool Personality
        {
            get { return _personlity; }
            set { _personlity = value; }
        }

        public WeaponType Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }

        public int IslandLocationId
        {
            get { return _islandLocationId; }
            set { _islandLocationId = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Character()
        {

        }

        public Character(string name, GenderType race, int islandLocationID)
        {
            _name = name;
            _gender= race;
            _islandLocationId = islandLocationID;
        }

        #endregion

        #region METHODS

        /// <summary>
        /// sets character's greeting based on their personlity
        /// </summary>        
        public virtual string Greeting()
        {
            if (_personlity)
            {
                return $"Hello! My name is {_name}!";
            }
            else
            {
                return $"Leave me alone.";
            }
        }  

        /// <summary>
        /// sets a character's personlity type (friendly or mean)
        /// </summary>        
        public virtual string PersonlityDescription()
        {
            if (_personlity)
            {
                return "Friendly; You are charismatic and people generally like you.";
            }
            else
            {
                return "Mean; You're a rude cut throat, most people wont give you the time of day.";
            }
        }

        #endregion
    }
}
