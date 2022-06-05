using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class HeatWave : PokeMove
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
            get { return _instance ?? (_instance = new HeatWave()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private HeatWave()
            : base(
                257,
                "Heat Wave",
                "Canicule",
                "The user attacks by exhaling hot breath on opposing Pokémon. This may also leave those Pokémon with a burn.",
                "Le lanceur provoque une vague de chaleur. Peut aussi brûler l’ennemi.",
                95,
                90,
                DamageClass.Special,
                TypeFire.Instance
            ) { }
        #endregion
    }
}