using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Flying
{
    internal class Bounce : PokeMove
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
            get { return _instance ?? (_instance = new Bounce()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Bounce()
            : base(
                340,
                "Bounce",
                "Rebond",
                "The user bounces up high, then drops on the target on the second turn. This may also leave the target with paralysis.",
                "Le lanceur bondit très haut et plonge sur l’ennemi au second tour. Peut aussi le paralyser.",
                85,
                85,
                DamageClass.Physical,
                TypeFlying.Instance
            ) { }
        #endregion
    }
}