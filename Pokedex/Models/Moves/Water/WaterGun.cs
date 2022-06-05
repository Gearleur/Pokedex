using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class WaterGun : PokeMove
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
            get { return _instance ?? (_instance = new WaterGun()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private WaterGun()
            : base(
                55,
                "Water Gun",
                "Pistolet à O",
                "The target is blasted with a forceful shot of water.",
                "De l’eau est projetée avec force sur l’ennemi.",
                40,
                100,
                DamageClass.Special,
                TypeWater.Instance
            ) { }
        #endregion
    }
}