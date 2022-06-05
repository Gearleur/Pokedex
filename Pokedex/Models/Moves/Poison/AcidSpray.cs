using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Poison
{
    internal class AcidSpray : PokeMove
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
            get { return _instance ?? (_instance = new AcidSpray()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private AcidSpray()
            : base(
                491,
                "Acid Spray",
                "Bombe Acide",
                "The user spits fluid that works to melt the target. This harshly lowers the target’s Sp. Def stat.",
                "Projette un liquide acide qui fait fondre l’ennemi. Sa Défense Spéciale diminue beaucoup.",
                40,
                100,
                DamageClass.Special,
                TypePoison.Instance
            ) { }
        #endregion
    }
}