using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dragon
{
    internal class DragonTail : PokeMove
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
            get { return _instance ?? (_instance = new DragonTail()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DragonTail()
            : base(
                525,
                "Dragon Tail",
                "Draco-Queue",
                "The target is knocked away, and a different Pokémon is dragged out. In the wild, this ends a battle against a single Pokémon.",
                "Un coup puissant qui blesse la cible et l’envoie au loin. Lors d’un combat contre un Pokémon sauvage seul, met fin au combat.",
                60,
                90,
                DamageClass.Physical,
                TypeDragon.Instance
            ) { }
        #endregion
    }
}