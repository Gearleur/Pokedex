using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ice
{
    internal class PowderSnow : PokeMove
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
            get { return _instance ?? (_instance = new PowderSnow()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private PowderSnow()
            : base(
                181,
                "Powder Snow",
                "Poudreuse",
                "The user attacks with a chilling gust of powdery snow. This may also freeze opposing Pokémon.",
                "Le lanceur projette de la neige poudreuse. Peut aussi geler l’ennemi.",
                40,
                100,
                DamageClass.Special,
                TypeIce.Instance
            ) { }
        #endregion
    }
}