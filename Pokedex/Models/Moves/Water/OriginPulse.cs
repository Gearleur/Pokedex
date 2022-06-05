using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class OriginPulse : PokeMove
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
            get { return _instance ?? (_instance = new OriginPulse()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private OriginPulse()
            : base(
                618,
                "Origin Pulse",
                "Onde Originelle",
                "The user attacks opposing Pokémon with countless beams of light that glow a deep and brilliant blue.",
                "D’innombrables rayons lumineux d’un bleu étincelant s’abattent sur la cible.",
                110,
                85,
                DamageClass.Special,
                TypeWater.Instance
            ) { }
        #endregion
    }
}