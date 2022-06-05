using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dark
{
    internal class WickedBlow : PokeMove
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
            get { return _instance ?? (_instance = new WickedBlow()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private WickedBlow()
            : base(
                817,
                "Wicked Blow",
                "Poing Obscur",
                "The user, having mastered the Dark style, strikes the target with a fierce blow. This attack always results in a critical hit.",
                "Le lanceur assène un coup puissant à l’ennemi. Cette technique qui inflige toujours un coup critique est réservée à ceux qui maîtrisent la puissance des Ténèbres.",
                80,
                100,
                DamageClass.Physical,
                TypeDark.Instance
            ) { }
        #endregion
    }
}