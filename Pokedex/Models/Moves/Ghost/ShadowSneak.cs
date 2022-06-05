using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ghost
{
    internal class ShadowSneak : PokeMove
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
            get { return _instance ?? (_instance = new ShadowSneak()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private ShadowSneak()
            : base(
                425,
                "Shadow Sneak",
                "Ombre Portée",
                "The user extends its shadow and attacks the target from behind. This move always goes first.",
                "Le lanceur étend son ombre pour frapper par-derrière. Frappe en priorité.",
                40,
                100,
                DamageClass.Physical,
                TypeGhost.Instance
            ) { }
        #endregion
    }
}