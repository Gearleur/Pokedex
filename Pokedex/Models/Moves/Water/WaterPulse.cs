using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class WaterPulse : PokeMove
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
            get { return _instance ?? (_instance = new WaterPulse()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private WaterPulse()
            : base(
                352,
                "Water Pulse",
                "Vibraqua",
                "The user attacks the target with a pulsing blast of water. This may also confuse the target.",
                "Le lanceur envoie un puissant jet d’eau sur l’ennemi. Peut le rendre confus.",
                60,
                100,
                DamageClass.Special,
                TypeWater.Instance
            ) { }
        #endregion
    }
}