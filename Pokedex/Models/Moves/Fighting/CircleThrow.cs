using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fighting
{
    internal class CircleThrow : PokeMove
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
            get { return _instance ?? (_instance = new CircleThrow()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private CircleThrow()
            : base(
                509,
                "Circle Throw",
                "Projection",
                "The target is thrown, and a different Pokémon is dragged out. In the wild, this ends a battle against a single Pokémon.",
                "Projette le Pokémon ennemi et le remplace par un autre. Lors d’un combat contre un Pokémon sauvage seul, met fin au combat.",
                60,
                90,
                DamageClass.Physical,
                TypeFighting.Instance
            ) { }
        #endregion
    }
}