using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class SnipeShot : PokeMove
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
            get { return _instance ?? (_instance = new SnipeShot()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SnipeShot()
            : base(
                745,
                "Snipe Shot",
                "Tir de Précision",
                "The user ignores the effects of opposing Pokémon’s moves and Abilities that draw in moves, allowing this move to hit the chosen target.",
                "Le lanceur parvient toujours à viser la cible voulue, en ignorant l’effet des talents et des capacités capables de détourner les attaques.",
                80,
                100,
                DamageClass.Special,
                TypeWater.Instance
            ) { }
        #endregion
    }
}