using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class FishiousRend : PokeMove
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
            get { return _instance ?? (_instance = new FishiousRend()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FishiousRend()
            : base(
                755,
                "Fishious Rend",
                "Branchicrok",
                "The user rends the target with its hard gills. If the user attacks before the target, the power of this move is doubled.",
                "Le lanceur mord sa cible avec ses solides branchies. Si cette capacité est lancée avant que la cible n’attaque, elle infligera deux fois plus de dégâts.",
                85,
                100,
                DamageClass.Physical,
                TypeWater.Instance
            ) { }
        #endregion
    }
}