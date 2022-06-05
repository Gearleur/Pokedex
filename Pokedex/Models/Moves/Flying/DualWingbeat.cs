using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Flying
{
    internal class DualWingbeat : PokeMove
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
            get { return _instance ?? (_instance = new DualWingbeat()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DualWingbeat()
            : base(
                814,
                "Dual Wingbeat",
                "Double Volée",
                "The user slams the target with its wings. The target is hit twice in a row.",
                "Le lanceur frappe l’ennemi avec ses ailes deux fois d’affilée.",
                40,
                90,
                DamageClass.Physical,
                TypeFlying.Instance
            ) { }
        #endregion
    }
}