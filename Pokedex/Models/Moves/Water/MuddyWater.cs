using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class MuddyWater : PokeMove
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
            get { return _instance ?? (_instance = new MuddyWater()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private MuddyWater()
            : base(
                330,
                "Muddy Water",
                "Ocroupi",
                "The user attacks by shooting muddy water at opposing Pokémon. This may also lower their accuracy.",
                "Le lanceur attaque en projetant de l’eau boueuse. Peut aussi réduire la Précision de l’ennemi.",
                90,
                85,
                DamageClass.Special,
                TypeWater.Instance
            ) { }
        #endregion
    }
}