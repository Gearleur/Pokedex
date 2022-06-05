using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Steel
{
    internal class BehemothBlade : PokeMove
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
            get { return _instance ?? (_instance = new BehemothBlade()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private BehemothBlade()
            : base(
                781,
                "Behemoth Blade",
                "Gladius Maximus",
                "The user becomes a gigantic sword and cuts the target. This move deals twice the damage if the target is Dynamaxed.",
                "Le lanceur se transforme en une immense épée et pourfend son adversaire. Inflige le double de dégâts aux Pokémon Dynamax.",
                100,
                100,
                DamageClass.Physical,
                TypeSteel.Instance
            ) { }
        #endregion
    }
}