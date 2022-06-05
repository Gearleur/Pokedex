using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ground
{
    internal class EarthPower : PokeMove
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
            get { return _instance ?? (_instance = new EarthPower()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private EarthPower()
            : base(
                414,
                "Earth Power",
                "Telluriforce",
                "The user makes the ground under the target erupt with power. This may also lower the target’s Sp. Def stat.",
                "De terribles séismes secouent l’ennemi. Peut aussi baisser sa Défense Spéciale.",
                90,
                100,
                DamageClass.Special,
                TypeGround.Instance
            ) { }
        #endregion
    }
}