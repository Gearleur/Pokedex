using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Poison
{
    internal class Venoshock : PokeMove
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
            get { return _instance ?? (_instance = new Venoshock()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Venoshock()
            : base(
                474,
                "Venoshock",
                "Choc Venin",
                "The user drenches the target in a special poisonous liquid. This move’s power is doubled if the target is poisoned.",
                "Le lanceur inocule un poison spécial à l’ennemi. L’effet est doublé si l’ennemi est déjà empoisonné.",
                65,
                100,
                DamageClass.Special,
                TypePoison.Instance
            ) { }
        #endregion
    }
}