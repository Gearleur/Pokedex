using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ghost
{
    internal class SpectralThief : PokeMove
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
            get { return _instance ?? (_instance = new SpectralThief()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SpectralThief()
            : base(
                712,
                "Spectral Thief",
                "Clepto-Mânes",
                "The user hides in the target’s shadow, steals the target’s stat boosts, and then attacks.",
                "Le lanceur plonge dans l’ombre de la cible, vole ses augmentations de stats et l’attaque.",
                90,
                100,
                DamageClass.Physical,
                TypeGhost.Instance
            ) { }
        #endregion
    }
}