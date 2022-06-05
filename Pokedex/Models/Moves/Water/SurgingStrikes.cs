using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class SurgingStrikes : PokeMove
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
            get { return _instance ?? (_instance = new SurgingStrikes()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SurgingStrikes()
            : base(
                818,
                "Surging Strikes",
                "Torrent de Coups",
                "The user, having mastered the Water style, strikes the target with a flowing motion three times in a row. This attack always results in a critical hit.",
                "Le lanceur assène trois coups fluides à l’ennemi. Cette technique qui inflige toujours un coup critique est réservée à ceux qui maîtrisent la puissance de l’Eau.",
                25,
                100,
                DamageClass.Physical,
                TypeWater.Instance
            ) { }
        #endregion
    }
}