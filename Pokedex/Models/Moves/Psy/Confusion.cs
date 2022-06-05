using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Psy
{
    internal class Confusion : PokeMove
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
            get { return _instance ?? (_instance = new Confusion()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Confusion()
            : base(
                93,
                "Confusion",
                "Choc Mental",
                "The target is hit by a weak telekinetic force. This may also confuse the target.",
                "Une faible vague télékinétique frappe l’ennemi. Peut aussi le plonger dans la confusion.",
                50,
                100,
                DamageClass.Special,
                TypePsy.Instance
            ) { }
        #endregion
    }
}