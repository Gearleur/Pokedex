using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Electric
{
    internal class WildCharge : PokeMove
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
            get { return _instance ?? (_instance = new WildCharge()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private WildCharge()
            : base(
                528,
                "Wild Charge",
                "Éclair Fou",
                "The user shrouds itself in electricity and smashes into its target. This also damages the user a little.",
                "Une charge électrique violente qui blesse aussi légèrement le lanceur.",
                90,
                100,
                DamageClass.Physical,
                TypeElectric.Instance
            ) { }
        #endregion
    }
}