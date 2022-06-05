using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Electric
{
    internal class ThunderCage : PokeMove
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
            get { return _instance ?? (_instance = new ThunderCage()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private ThunderCage()
            : base(
                819,
                "Thunder Cage",
                "Voltageôle",
                "The user traps the target in a cage of sparking electricity for four to five turns.",
                "Le lanceur frappe l’ennemi, et le piège dans une prison électrique qui dure de quatre à cinq tours.",
                80,
                90,
                DamageClass.Special,
                TypeElectric.Instance
            ) { }
        #endregion
    }
}