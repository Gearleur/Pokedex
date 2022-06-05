using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Psy
{
    internal class PrismaticLaser : PokeMove
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
            get { return _instance ?? (_instance = new PrismaticLaser()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private PrismaticLaser()
            : base(
                711,
                "Prismatic Laser",
                "Laser Prisme",
                "The user shoots powerful lasers using the power of a prism. The user can’t move on the next turn.",
                "Le lanceur utilise la puissance d’un prisme pour envoyer un laser destructeur, mais il doit se reposer au tour suivant.",
                160,
                100,
                DamageClass.Special,
                TypePsy.Instance
            ) { }
        #endregion
    }
}