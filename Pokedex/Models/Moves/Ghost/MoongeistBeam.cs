using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ghost
{
    internal class MoongeistBeam : PokeMove
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
            get { return _instance ?? (_instance = new MoongeistBeam()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private MoongeistBeam()
            : base(
                714,
                "Moongeist Beam",
                "Rayon Spectral",
                "The user emits a sinister ray to attack the target. This move can be used on the target regardless of its Abilities.",
                "Le lanceur attaque avec un rayon de lumière mystérieux. Ignore le talent de la cible.",
                100,
                100,
                DamageClass.Special,
                TypeGhost.Instance
            ) { }
        #endregion
    }
}