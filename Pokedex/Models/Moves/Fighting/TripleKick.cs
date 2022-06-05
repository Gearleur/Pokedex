using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fighting
{
    internal class TripleKick : PokeMove
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
            get { return _instance ?? (_instance = new TripleKick()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private TripleKick()
            : base(
                167,
                "Triple Kick",
                "Triple Pied",
                "A consecutive three-kick attack that becomes more powerful with each successful hit.",
                "Une salve de un à trois coups de pied dont la puissance augmente à chaque coup porté.",
                10,
                90,
                DamageClass.Physical,
                TypeFighting.Instance
            ) { }
        #endregion
    }
}