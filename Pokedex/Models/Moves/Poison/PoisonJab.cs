using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Poison
{
    internal class PoisonJab : PokeMove
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
            get { return _instance ?? (_instance = new PoisonJab()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private PoisonJab()
            : base(
                398,
                "Poison Jab",
                "Direct Toxik",
                "The target is stabbed with a tentacle, arm, or the like steeped in poison. This may also poison the target.",
                "Attaque l’ennemi avec un tentacule, un bras, ou un autre membre plein de poison. Peut aussi l’empoisonner.",
                80,
                100,
                DamageClass.Physical,
                TypePoison.Instance
            ) { }
        #endregion
    }
}