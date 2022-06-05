using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Poison
{
    internal class Sludge : PokeMove
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
            get { return _instance ?? (_instance = new Sludge()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Sludge()
            : base(
                124,
                "Sludge",
                "Détritus",
                "Unsanitary sludge is hurled at the target. This may also poison the target.",
                "Des détritus toxiques sont projetés sur l’ennemi. Peut aussi l’empoisonner.",
                65,
                100,
                DamageClass.Special,
                TypePoison.Instance
            ) { }
        #endregion
    }
}