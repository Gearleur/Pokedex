using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Bug
{
    internal class PinMissile : PokeMove
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
            get { return _instance ?? (_instance = new PinMissile()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private PinMissile()
            : base(
                42,
                "Pin Missile",
                "Dard-Nuée",
                "Sharp spikes are shot at the target in rapid succession. They hit two to five times in a row.",
                "Envoie une rafale de dards. Peut toucher de deux à cinq fois.",
                25,
                95,
                DamageClass.Physical,
                TypeBug.Instance
            ) { }
        #endregion
    }
}