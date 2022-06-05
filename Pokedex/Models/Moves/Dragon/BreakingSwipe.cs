using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dragon
{
    internal class BreakingSwipe : PokeMove
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
            get { return _instance ?? (_instance = new BreakingSwipe()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private BreakingSwipe()
            : base(
                784,
                "Breaking Swipe",
                "Abattage",
                "The user swings its tough tail wildly and attacks opposing Pokémon. This also lowers their Attack stats.",
                "Le lanceur balaie violemment le camp adverse avec son immense queue. Baisse l’Attaque de la cible.",
                60,
                100,
                DamageClass.Physical,
                TypeDragon.Instance
            ) { }
        #endregion
    }
}