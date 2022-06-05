using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Rock
{
    internal class RockThrow : PokeMove
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
            get { return _instance ?? (_instance = new RockThrow()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private RockThrow()
            : base(
                88,
                "Rock Throw",
                "Jet-Pierres",
                "The user picks up and throws a small rock at the target to attack.",
                "Le lanceur lâche une pierre sur l’ennemi.",
                50,
                90,
                DamageClass.Physical,
                TypeRock.Instance
            ) { }
        #endregion
    }
}