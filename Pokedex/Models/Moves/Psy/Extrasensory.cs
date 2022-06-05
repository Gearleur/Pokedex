using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Psy
{
    internal class Extrasensory : PokeMove
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
            get { return _instance ?? (_instance = new Extrasensory()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Extrasensory()
            : base(
                326,
                "Extrasensory",
                "Extrasenseur",
                "The user attacks with an odd, unseeable power. This may also make the target flinch.",
                "Le lanceur attaque avec un pouvoir étrange et invisible. Peut aussi apeurer l’ennemi.",
                80,
                100,
                DamageClass.Special,
                TypePsy.Instance
            ) { }
        #endregion
    }
}