using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class FusionFlare : PokeMove
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
            get { return _instance ?? (_instance = new FusionFlare()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FusionFlare()
            : base(
                558,
                "Fusion Flare",
                "Flamme Croix",
                "The user brings down a giant flame. This move’s power is increased when influenced by an enormous lightning bolt.",
                "Projette une boule de feu gigantesque. L’effet augmente sous l’influence d’Éclair Croix.",
                100,
                100,
                DamageClass.Special,
                TypeFire.Instance
            ) { }
        #endregion
    }
}