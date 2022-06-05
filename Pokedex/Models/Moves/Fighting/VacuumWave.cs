using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fighting
{
    internal class VacuumWave : PokeMove
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
            get { return _instance ?? (_instance = new VacuumWave()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private VacuumWave()
            : base(
                410,
                "Vacuum Wave",
                "Onde Vide",
                "The user whirls its fists to send a wave of pure vacuum at the target. This move always goes first.",
                "Le lanceur agite son poing pour projeter une onde de vide. Frappe en priorité.",
                40,
                100,
                DamageClass.Special,
                TypeFighting.Instance
            ) { }
        #endregion
    }
}