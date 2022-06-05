using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class HydroPump : PokeMove
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
            get { return _instance ?? (_instance = new HydroPump()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private HydroPump()
            : base(
                56,
                "Hydro Pump",
                "Hydrocanon",
                "The target is blasted by a huge volume of water launched under great pressure.",
                "Un puissant jet d’eau est dirigé sur l’ennemi.",
                110,
                80,
                DamageClass.Special,
                TypeWater.Instance
            ) { }
        #endregion
    }
}