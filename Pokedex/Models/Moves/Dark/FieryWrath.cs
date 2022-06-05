using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dark
{
    internal class FieryWrath : PokeMove
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
            get { return _instance ?? (_instance = new FieryWrath()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FieryWrath()
            : base(
                822,
                "Fiery Wrath",
                "Fureur Ardente",
                "The user transforms its wrath into a fire-like aura to attack. This may also make opposing Pokémon flinch.",
                "Le lanceur canalise sa colère et la transforme en aura brûlante, avec laquelle il attaque l’ennemi. Peut aussi l’apeurer.",
                90,
                100,
                DamageClass.Special,
                TypeDark.Instance
            ) { }
        #endregion
    }
}