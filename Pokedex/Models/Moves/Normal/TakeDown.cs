using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class TakeDown : PokeMove
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
            get { return _instance ?? (_instance = new TakeDown()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private TakeDown()
            : base(
                36,
                "Take Down",
                "Bélier",
                "A reckless, full-body charge attack for slamming into the target. This also damages the user a little.",
                "Une charge violente qui blesse aussi légèrement le lanceur.",
                90,
                85,
                DamageClass.Physical,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}