using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class WaterShuriken : PokeMove
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
            get { return _instance ?? (_instance = new WaterShuriken()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private WaterShuriken()
            : base(
                594,
                "Water Shuriken",
                "Sheauriken",
                "The user hits the target with throwing stars two to five times in a row. This move always goes first.",
                "Attaque l’ennemi avec des shuriken de mucus. Frappe en priorité deux à cinq fois d’affilée en un tour.",
                15,
                100,
                DamageClass.Special,
                TypeWater.Instance
            ) { }
        #endregion
    }
}