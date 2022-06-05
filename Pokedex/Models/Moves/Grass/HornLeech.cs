using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Grass
{
    internal class HornLeech : PokeMove
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
            get { return _instance ?? (_instance = new HornLeech()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private HornLeech()
            : base(
                532,
                "Horn Leech",
                "Encornebois",
                "The user drains the target’s energy with its horns. The user’s HP is restored by half the damage taken by the target.",
                "Un coup de corne qui draine l’énergie de l’ennemi. Convertit la moitié des dégâts infligés en PV pour le lanceur.",
                75,
                100,
                DamageClass.Physical,
                TypeGrass.Instance
            ) { }
        #endregion
    }
}