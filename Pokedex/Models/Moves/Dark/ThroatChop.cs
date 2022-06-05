using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dark
{
    internal class ThroatChop : PokeMove
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
            get { return _instance ?? (_instance = new ThroatChop()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private ThroatChop()
            : base(
                675,
                "Throat Chop",
                "Exécu-Son",
                "The user attacks the target’s throat, and the resultant suffering prevents the target from using moves that emit sound for two turns.",
                "Inflige une douleur tellement violente à la cible qu’elle ne peut plus émettre de sons pendant deux tours.",
                80,
                100,
                DamageClass.Physical,
                TypeDark.Instance
            ) { }
        #endregion
    }
}