using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class WaterPledge : PokeMove
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
            get { return _instance ?? (_instance = new WaterPledge()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private WaterPledge()
            : base(
                518,
                "Water Pledge",
                "Aire d’Eau",
                "A column of water hits the target. When used with its fire equivalent, its power increases and a rainbow appears.",
                "Une masse d’eau s’abat sur l’ennemi. En l’utilisant avec Aire de Feu, l’effet augmente et un arc-en-ciel apparaît.",
                80,
                100,
                DamageClass.Special,
                TypeWater.Instance
            ) { }
        #endregion
    }
}