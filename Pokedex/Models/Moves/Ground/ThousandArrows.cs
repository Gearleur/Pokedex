using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ground
{
    internal class ThousandArrows : PokeMove
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
            get { return _instance ?? (_instance = new ThousandArrows()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private ThousandArrows()
            : base(
                614,
                "Thousand Arrows",
                "Myria-Flèches",
                "This move also hits opposing Pokémon that are in the air. Those Pokémon are knocked down to the ground.",
                "Touche même les Pokémon dans les airs. Dans ce cas, la cible retombe au sol.",
                90,
                100,
                DamageClass.Physical,
                TypeGround.Instance
            ) { }
        #endregion
    }
}