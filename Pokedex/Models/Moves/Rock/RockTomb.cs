using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Rock
{
    internal class RockTomb : PokeMove
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
            get { return _instance ?? (_instance = new RockTomb()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private RockTomb()
            : base(
                317,
                "Rock Tomb",
                "Tomberoche",
                "Boulders are hurled at the target. This also lowers the target’s Speed stat by preventing its movement.",
                "Des rochers frappent l’ennemi. Réduit aussi sa Vitesse.",
                60,
                95,
                DamageClass.Physical,
                TypeRock.Instance
            ) { }
        #endregion
    }
}