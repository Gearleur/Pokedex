using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Grass
{
    internal class GrassPledge : PokeMove
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
            get { return _instance ?? (_instance = new GrassPledge()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private GrassPledge()
            : base(
                520,
                "Grass Pledge",
                "Aire d’Herbe",
                "A column of grass hits the target. When used with its water equivalent, its power increases and a vast swamp appears.",
                "Une masse végétale s’abat sur l’ennemi. En l’utilisant avec Aire d’Eau, l’effet augmente et un marécage apparaît.",
                80,
                100,
                DamageClass.Special,
                TypeGrass.Instance
            ) { }
        #endregion
    }
}