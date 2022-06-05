using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Flying
{
    internal class AirSlash : PokeMove
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
            get { return _instance ?? (_instance = new AirSlash()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private AirSlash()
            : base(
                403,
                "Air Slash",
                "Lame d’Air",
                "The user attacks with a blade of air that slices even the sky. This may also make the target flinch.",
                "Le lanceur attaque avec une lame d’air qui fend tout. Peut aussi apeurer l’ennemi.",
                75,
                95,
                DamageClass.Special,
                TypeFlying.Instance
            ) { }
        #endregion
    }
}