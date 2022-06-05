using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Flying
{
    internal class AirCutter : PokeMove
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
            get { return _instance ?? (_instance = new AirCutter()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private AirCutter()
            : base(
                314,
                "Air Cutter",
                "Tranch’Air",
                "The user launches razor-like wind to slash opposing Pokémon. Critical hits land more easily.",
                "Le lanceur appelle des vents tranchants qui lacèrent l’ennemi. Taux de critiques élevé.",
                60,
                95,
                DamageClass.Special,
                TypeFlying.Instance
            ) { }
        #endregion
    }
}