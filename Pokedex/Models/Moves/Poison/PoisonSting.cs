using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Poison
{
    internal class PoisonSting : PokeMove
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
            get { return _instance ?? (_instance = new PoisonSting()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private PoisonSting()
            : base(
                40,
                "Poison Sting",
                "Dard-Venin",
                "The user stabs the target with a poisonous stinger. This may also poison the target.",
                "Un dard toxique qui transperce l’ennemi. Peut aussi l’empoisonner.",
                15,
                100,
                DamageClass.Physical,
                TypePoison.Instance
            ) { }
        #endregion
    }
}