using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Flying
{
    internal class Hurricane : PokeMove
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
            get { return _instance ?? (_instance = new Hurricane()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Hurricane()
            : base(
                542,
                "Hurricane",
                "Vent Violent",
                "The user attacks by wrapping its opponent in a fierce wind that flies up into the sky. This may also confuse the target.",
                "Le lanceur déclenche une tempête de vents violents qui s’abat sur l’ennemi. Peut aussi le rendre confus.",
                110,
                70,
                DamageClass.Special,
                TypeFlying.Instance
            ) { }
        #endregion
    }
}