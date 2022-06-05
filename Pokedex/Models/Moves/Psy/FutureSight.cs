using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Psy
{
    internal class FutureSight : PokeMove
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
            get { return _instance ?? (_instance = new FutureSight()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FutureSight()
            : base(
                248,
                "Future Sight",
                "Prescience",
                "Two turns after this move is used, a hunk of psychic energy attacks the target.",
                "De l’énergie psychique vient frapper l’ennemi deux tours après l’utilisation de cette capacité.",
                120,
                100,
                DamageClass.Special,
                TypePsy.Instance
            ) { }
        #endregion
    }
}