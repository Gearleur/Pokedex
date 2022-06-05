using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Grass
{
    internal class SeedFlare : PokeMove
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
            get { return _instance ?? (_instance = new SeedFlare()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SeedFlare()
            : base(
                465,
                "Seed Flare",
                "Fulmigraine",
                "The user emits a shock wave from its body to attack its target. This may also harshly lower the target’s Sp. Def stat.",
                "Le corps du lanceur émet une onde de choc. Peut aussi beaucoup baisser la Défense Spéciale de la cible.",
                120,
                85,
                DamageClass.Special,
                TypeGrass.Instance
            ) { }
        #endregion
    }
}