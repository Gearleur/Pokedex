using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class Crabhammer : PokeMove
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
            get { return _instance ?? (_instance = new Crabhammer()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Crabhammer()
            : base(
                152,
                "Crabhammer",
                "Pince-Masse",
                "The target is hammered with a large pincer. Critical hits land more easily.",
                "Une grande pince martèle l’ennemi. Taux de critiques élevé.",
                100,
                90,
                DamageClass.Physical,
                TypeWater.Instance
            ) { }
        #endregion
    }
}