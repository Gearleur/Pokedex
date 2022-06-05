using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class HyperBeam : PokeMove
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
            get { return _instance ?? (_instance = new HyperBeam()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private HyperBeam()
            : base(
                63,
                "Hyper Beam",
                "Ultralaser",
                "The target is attacked with a powerful beam. The user can’t move on the next turn.",
                "Projette un puissant rayon sur l’ennemi. Le lanceur doit se reposer au tour suivant.",
                150,
                90,
                DamageClass.Special,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}