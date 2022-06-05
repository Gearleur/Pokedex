using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fairy
{
    internal class StrangeSteam : PokeMove
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
            get { return _instance ?? (_instance = new StrangeSteam()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private StrangeSteam()
            : base(
                790,
                "Strange Steam",
                "Vapeur Féérique",
                "The user attacks the target by emitting steam. This may also confuse the target.",
                "Le lanceur émet de la vapeur pour attaquer sa cible. Peut aussi la rendre confuse.",
                90,
                95,
                DamageClass.Special,
                TypeFairy.Instance
            ) { }
        #endregion
    }
}