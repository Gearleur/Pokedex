using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class BlastBurn : PokeMove
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
            get { return _instance ?? (_instance = new BlastBurn()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private BlastBurn()
            : base(
                307,
                "Blast Burn",
                "Rafale Feu",
                "The target is razed by a fiery explosion. The user can’t move on the next turn.",
                "Une explosion ardente souffle l’adversaire. Le lanceur doit se reposer au tour suivant.",
                150,
                90,
                DamageClass.Special,
                TypeFire.Instance
            ) { }
        #endregion
    }
}