using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ground
{
    internal class Bonemerang : PokeMove
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
            get { return _instance ?? (_instance = new Bonemerang()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Bonemerang()
            : base(
                155,
                "Bonemerang",
                "Osmerang",
                "The user throws the bone it holds. The bone loops around to hit the target twice—coming and going.",
                "Le lanceur projette son os comme un boomerang. Cette attaque frappe à l’aller et au retour.",
                50,
                90,
                DamageClass.Physical,
                TypeGround.Instance
            ) { }
        #endregion
    }
}