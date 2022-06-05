using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Rock
{
    internal class DiamondStorm : PokeMove
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
            get { return _instance ?? (_instance = new DiamondStorm()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DiamondStorm()
            : base(
                591,
                "Diamond Storm",
                "Orage Adamantin",
                "The user whips up a storm of diamonds to damage opposing Pokémon. This may also sharply raise the user’s Defense stat.",
                "Provoque une tempête de diamants qui inflige des dégâts. Peut beaucoup augmenter la Défense du lanceur.",
                100,
                95,
                DamageClass.Physical,
                TypeRock.Instance
            ) { }
        #endregion
    }
}