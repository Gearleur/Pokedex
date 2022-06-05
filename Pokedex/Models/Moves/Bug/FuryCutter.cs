using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Bug
{
    internal class FuryCutter : PokeMove
    {
        #region Variables
        /// <summary>
        /// Nullable variable (use of ? after type)
        /// </summary>
        private static PokeMove? _instance = null;
        #endregion

        #region Getters + Setters
        /// <summary>
        /// If no instance, create it
        /// </summary>
        public static PokeMove Instance
        {
            get { return _instance ?? (_instance = new FuryCutter()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FuryCutter()
            : base(
                210,
                "Fury Cutter",
                "Taillade",
                "The target is slashed with scythes or claws. This attack becomes more powerful if it hits in succession.",
                "Un coup de faux ou de griffe dont la force augmente quand il touche plusieurs fois d’affilée.",
                40,
                95,
                DamageClass.Physical,
                TypeBug.Instance
            ) { }
        #endregion
    }
}