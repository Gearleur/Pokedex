using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class HydroCannon : PokeMove
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
            get { return _instance ?? (_instance = new HydroCannon()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private HydroCannon()
            : base(
                308,
                "Hydro Cannon",
                "Hydroblast",
                "The target is hit with a watery blast. The user can’t move on the next turn.",
                "Une trombe d’eau heurte l’ennemi. Le lanceur doit se reposer au tour suivant.",
                150,
                90,
                DamageClass.Special,
                TypeWater.Instance
            ) { }
        #endregion
    }
}