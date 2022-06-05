using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Poison
{
    internal class CrossPoison : PokeMove
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
            get { return _instance ?? (_instance = new CrossPoison()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private CrossPoison()
            : base(
                440,
                "Cross Poison",
                "Poison Croix",
                "A slashing attack with a poisonous blade that may also poison the target. Critical hits land more easily.",
                "Un coup tranchant qui peut empoisonner l’ennemi. Taux de critiques élevé.",
                70,
                100,
                DamageClass.Physical,
                TypePoison.Instance
            ) { }
        #endregion
    }
}