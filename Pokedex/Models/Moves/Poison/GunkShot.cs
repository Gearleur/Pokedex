using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Poison
{
    internal class GunkShot : PokeMove
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
            get { return _instance ?? (_instance = new GunkShot()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private GunkShot()
            : base(
                441,
                "Gunk Shot",
                "Détricanon",
                "The user shoots filthy garbage at the target to attack. This may also poison the target.",
                "Le lanceur envoie des détritus sur l’ennemi. Peut aussi l’empoisonner.",
                120,
                80,
                DamageClass.Physical,
                TypePoison.Instance
            ) { }
        #endregion
    }
}