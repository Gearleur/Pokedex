using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fighting
{
    internal class MachPunch : PokeMove
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
            get { return _instance ?? (_instance = new MachPunch()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private MachPunch()
            : base(
                183,
                "Mach Punch",
                "Mach Punch",
                "The user throws a punch at blinding speed. This move always goes first.",
                "Coup de poing fulgurant. Frappe en priorité.",
                40,
                100,
                DamageClass.Physical,
                TypeFighting.Instance
            ) { }
        #endregion
    }
}