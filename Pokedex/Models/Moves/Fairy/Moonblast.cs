using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fairy
{
    internal class Moonblast : PokeMove
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
            get { return _instance ?? (_instance = new Moonblast()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Moonblast()
            : base(
                585,
                "Moonblast",
                "Pouvoir Lunaire",
                "Borrowing the power of the moon, the user attacks the target. This may also lower the target’s Sp. Atk stat.",
                "Attaque l’ennemi grâce au pouvoir de la lune. Peut diminuer son Attaque Spéciale.",
                95,
                100,
                DamageClass.Special,
                TypeFairy.Instance
            ) { }
        #endregion
    }
}