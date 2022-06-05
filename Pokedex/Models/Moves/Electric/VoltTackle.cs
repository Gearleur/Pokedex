using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Electric
{
    internal class VoltTackle : PokeMove
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
            get { return _instance ?? (_instance = new VoltTackle()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private VoltTackle()
            : base(
                344,
                "Volt Tackle",
                "Électacle",
                "The user electrifies itself and charges the target. This also damages the user quite a lot. This attack may leave the target with paralysis.",
                "Le lanceur électrifie son corps avant de charger. Le choc blesse aussi gravement le lanceur et peut paralyser l’ennemi.",
                120,
                100,
                DamageClass.Physical,
                TypeElectric.Instance
            ) { }
        #endregion
    }
}