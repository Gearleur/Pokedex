using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Poison
{
    internal class SludgeBomb : PokeMove
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
            get { return _instance ?? (_instance = new SludgeBomb()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SludgeBomb()
            : base(
                188,
                "Sludge Bomb",
                "Bombe Beurk",
                "Unsanitary sludge is hurled at the target. This may also poison the target.",
                "Des détritus toxiques sont projetés sur l’ennemi. Peut aussi l’empoisonner.",
                90,
                100,
                DamageClass.Special,
                TypePoison.Instance
            ) { }
        #endregion
    }
}