using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class AquaTail : PokeMove
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
            get { return _instance ?? (_instance = new AquaTail()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private AquaTail()
            : base(
                401,
                "Aqua Tail",
                "Hydro-Queue",
                "The user attacks by swinging its tail as if it were a vicious wave in a raging storm.",
                "Le lanceur attaque en balançant sa queue comme une lame de fond en pleine tempête.",
                90,
                90,
                DamageClass.Physical,
                TypeWater.Instance
            ) { }
        #endregion
    }
}