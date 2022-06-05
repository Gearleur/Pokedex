using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Electric
{
    internal class RisingVoltage : PokeMove
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
            get { return _instance ?? (_instance = new RisingVoltage()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private RisingVoltage()
            : base(
                804,
                "Rising Voltage",
                "Monte-Tension",
                "The user attacks with electric voltage rising from the ground. This move’s power doubles when the target is on Electric Terrain.",
                "Des éclairs surgissent du sol et frappent l’ennemi. La puissance de cette attaque est doublée si la cible est sur un Champ Électrifié.",
                70,
                100,
                DamageClass.Special,
                TypeElectric.Instance
            ) { }
        #endregion
    }
}