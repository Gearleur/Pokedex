using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dark
{
    internal class DarkPulse : PokeMove
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
            get { return _instance ?? (_instance = new DarkPulse()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DarkPulse()
            : base(
                399,
                "Dark Pulse",
                "Vibrobscur",
                "The user releases a horrible aura imbued with dark thoughts. This may also make the target flinch.",
                "Le lanceur dégage une horrible aura chargée de pensées maléfiques. Peut aussi apeurer l’ennemi.",
                80,
                100,
                DamageClass.Special,
                TypeDark.Instance
            ) { }
        #endregion
    }
}