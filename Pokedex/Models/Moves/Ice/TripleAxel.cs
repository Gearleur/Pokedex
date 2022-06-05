using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ice
{
    internal class TripleAxel : PokeMove
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
            get { return _instance ?? (_instance = new TripleAxel()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private TripleAxel()
            : base(
                813,
                "Triple Axel",
                "Triple Axel",
                "A consecutive three-kick attack that becomes more powerful with each successful hit.",
                "Une salve composée de un à trois coups de pied dont la puissance augmente à chaque coup porté.",
                20,
                90,
                DamageClass.Physical,
                TypeIce.Instance
            ) { }
        #endregion
    }
}