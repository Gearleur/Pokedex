using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Steel
{
    internal class BehemothBash : PokeMove
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
            get { return _instance ?? (_instance = new BehemothBash()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private BehemothBash()
            : base(
                782,
                "Behemoth Bash",
                "Aegis Maxima",
                "The user becomes a gigantic shield and slams into the target. This move deals twice the damage if the target is Dynamaxed.",
                "Le lanceur se transforme en un immense bouclier et charge son adversaire. Inflige le double de dégâts aux Pokémon Dynamax.",
                100,
                100,
                DamageClass.Physical,
                TypeSteel.Instance
            ) { }
        #endregion
    }
}