using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dark
{
    internal class PowerTrip : PokeMove
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
            get { return _instance ?? (_instance = new PowerTrip()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private PowerTrip()
            : base(
                681,
                "Power Trip",
                "Arrogance",
                "The user boasts its strength and attacks the target. The more the user’s stats are raised, the greater the move’s power.",
                "Ivre de puissance, le lanceur attaque de toutes ses forces. Plus ses stats ont été augmentées, plus la puissance de l’attaque est élevée.",
                20,
                100,
                DamageClass.Physical,
                TypeDark.Instance
            ) { }
        #endregion
    }
}