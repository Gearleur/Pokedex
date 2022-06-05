using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class FurySwipes : PokeMove
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
            get { return _instance ?? (_instance = new FurySwipes()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FurySwipes()
            : base(
                154,
                "Fury Swipes",
                "Combo-Griffe",
                "The target is raked with sharp claws or scythes quickly two to five times in a row.",
                "L’ennemi est lacéré par des faux ou des griffes de deux à cinq fois d’affilée.",
                18,
                80,
                DamageClass.Physical,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}