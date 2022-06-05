using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Poison
{
    internal class PoisonTail : PokeMove
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
            get { return _instance ?? (_instance = new PoisonTail()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private PoisonTail()
            : base(
                342,
                "Poison Tail",
                "Queue-Poison",
                "The user hits the target with its tail. This may also poison the target. Critical hits land more easily.",
                "Attaque à taux de critiques élevé. Peut aussi empoisonner l’ennemi.",
                50,
                100,
                DamageClass.Physical,
                TypePoison.Instance
            ) { }
        #endregion
    }
}