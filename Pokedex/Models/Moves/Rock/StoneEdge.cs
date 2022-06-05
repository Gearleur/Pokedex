using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Rock
{
    internal class StoneEdge : PokeMove
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
            get { return _instance ?? (_instance = new StoneEdge()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private StoneEdge()
            : base(
                444,
                "Stone Edge",
                "Lame de Roc",
                "The user stabs the target from below with sharpened stones. Critical hits land more easily.",
                "Fait surgir des pierres aiguisées sous l’ennemi. Taux de critiques élevé.",
                100,
                80,
                DamageClass.Physical,
                TypeRock.Instance
            ) { }
        #endregion
    }
}