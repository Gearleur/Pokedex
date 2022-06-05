using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Grass
{
    internal class GigaDrain : PokeMove
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
            get { return _instance ?? (_instance = new GigaDrain()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private GigaDrain()
            : base(
                202,
                "Giga Drain",
                "Giga-Sangsue",
                "A nutrient-draining attack. The user’s HP is restored by half the damage taken by the target.",
                "Une attaque qui convertit la moitié des dégâts infligés en PV pour le lanceur.",
                75,
                100,
                DamageClass.Special,
                TypeGrass.Instance
            ) { }
        #endregion
    }
}