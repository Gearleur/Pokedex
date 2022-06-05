using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Steel
{
    internal class FlashCannon : PokeMove
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
            get { return _instance ?? (_instance = new FlashCannon()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FlashCannon()
            : base(
                430,
                "Flash Cannon",
                "Luminocanon",
                "The user gathers all its light energy and releases it all at once. This may also lower the target’s Sp. Def stat.",
                "Le lanceur concentre son énergie lumineuse et la fait exploser. Peut aussi baisser la Défense Spéciale de l’ennemi.",
                80,
                100,
                DamageClass.Special,
                TypeSteel.Instance
            ) { }
        #endregion
    }
}