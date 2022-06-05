using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class Liquidation : PokeMove
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
            get { return _instance ?? (_instance = new Liquidation()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Liquidation()
            : base(
                710,
                "Liquidation",
                "Aqua-Brèche",
                "The user slams into the target using a full-force blast of water. This may also lower the target’s Defense stat.",
                "Le lanceur utilise la force de l’eau pour attaquer. Peut aussi baisser la Défense de la cible.",
                85,
                100,
                DamageClass.Physical,
                TypeWater.Instance
            ) { }
        #endregion
    }
}