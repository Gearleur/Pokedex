using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fighting
{
    internal class CrossChop : PokeMove
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
            get { return _instance ?? (_instance = new CrossChop()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private CrossChop()
            : base(
                238,
                "Cross Chop",
                "Coup Croix",
                "The user delivers a double chop with its forearms crossed. Critical hits land more easily.",
                "Le lanceur délivre un coup double en croisant les avant-bras. Taux de critiques élevé.",
                100,
                80,
                DamageClass.Physical,
                TypeFighting.Instance
            ) { }
        #endregion
    }
}