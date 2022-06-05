using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Grass
{
    internal class SeedBomb : PokeMove
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
            get { return _instance ?? (_instance = new SeedBomb()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SeedBomb()
            : base(
                402,
                "Seed Bomb",
                "Canon Graine",
                "The user slams a barrage of hard-shelled seeds down on the target from above.",
                "Le lanceur fait pleuvoir un déluge de graines explosives sur l’ennemi.",
                80,
                100,
                DamageClass.Physical,
                TypeGrass.Instance
            ) { }
        #endregion
    }
}