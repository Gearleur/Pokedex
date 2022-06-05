using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class GigaImpact : PokeMove
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
            get { return _instance ?? (_instance = new GigaImpact()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private GigaImpact()
            : base(
                416,
                "Giga Impact",
                "Giga Impact",
                "The user charges at the target using every bit of its power. The user can’t move on the next turn.",
                "Le lanceur charge l’ennemi de toute sa puissance et doit ensuite se reposer au tour suivant.",
                150,
                90,
                DamageClass.Physical,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}