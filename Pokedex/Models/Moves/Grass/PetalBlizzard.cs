using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Grass
{
    internal class PetalBlizzard : PokeMove
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
            get { return _instance ?? (_instance = new PetalBlizzard()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private PetalBlizzard()
            : base(
                572,
                "Petal Blizzard",
                "Tempête Florale",
                "The user stirs up a violent petal blizzard and attacks everything around it.",
                "Déclenche une violente tempête de fleurs qui inflige des dégâts à tous les Pokémon alentour.",
                90,
                100,
                DamageClass.Physical,
                TypeGrass.Instance
            ) { }
        #endregion
    }
}