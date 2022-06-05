using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dark
{
    internal class Snarl : PokeMove
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
            get { return _instance ?? (_instance = new Snarl()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Snarl()
            : base(
                555,
                "Snarl",
                "Aboiement",
                "The user yells as if it’s ranting about something, which lowers the Sp. Atk stats of opposing Pokémon.",
                "Le lanceur hurle sur l’ennemi. Baisse l’Attaque Spéciale de l’ennemi.",
                55,
                95,
                DamageClass.Special,
                TypeDark.Instance
            ) { }
        #endregion
    }
}