using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Psy
{
    internal class Psychic : PokeMove
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
            get { return _instance ?? (_instance = new Psychic()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Psychic()
            : base(
                94,
                "Psychic",
                "Psyko",
                "The target is hit by a strong telekinetic force. This may also lower the target’s Sp. Def stat.",
                "Une puissante force télékinétique frappe l’ennemi. Peut aussi faire baisser sa Défense Spéciale.",
                90,
                100,
                DamageClass.Special,
                TypePsy.Instance
            ) { }
        #endregion
    }
}