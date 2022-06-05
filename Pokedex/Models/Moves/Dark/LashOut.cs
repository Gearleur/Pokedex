using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dark
{
    internal class LashOut : PokeMove
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
            get { return _instance ?? (_instance = new LashOut()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private LashOut()
            : base(
                808,
                "Lash Out",
                "Cent Rancunes",
                "The user lashes out to vent its frustration toward the target. If the user’s stats were lowered during this turn, the power of this move is doubled.",
                "Le lanceur frappe l’ennemi avec toute sa rancune. Si les stats du lanceur ont diminué pendant ce tour, la puissance de cette attaque est doublée.",
                75,
                100,
                DamageClass.Physical,
                TypeDark.Instance
            ) { }
        #endregion
    }
}