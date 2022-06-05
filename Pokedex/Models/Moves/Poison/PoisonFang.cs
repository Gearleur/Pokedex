using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Poison
{
    internal class PoisonFang : PokeMove
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
            get { return _instance ?? (_instance = new PoisonFang()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private PoisonFang()
            : base(
                305,
                "Poison Fang",
                "Crochet Venin",
                "The user bites the target with toxic fangs. This may also leave the target badly poisoned.",
                "Le lanceur mord l’ennemi de ses crocs toxiques. Peut aussi l’empoisonner gravement.",
                50,
                100,
                DamageClass.Physical,
                TypePoison.Instance
            ) { }
        #endregion
    }
}