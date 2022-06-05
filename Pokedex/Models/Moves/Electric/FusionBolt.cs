using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Electric
{
    internal class FusionBolt : PokeMove
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
            get { return _instance ?? (_instance = new FusionBolt()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FusionBolt()
            : base(
                559,
                "Fusion Bolt",
                "Éclair Croix",
                "The user throws down a giant lightning bolt. This move’s power is increased when influenced by an enormous flame.",
                "Projette un orbe électrique gigantesque. L’effet augmente sous l’influence de Flamme Croix.",
                100,
                100,
                DamageClass.Physical,
                TypeElectric.Instance
            ) { }
        #endregion
    }
}