using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Grass
{
    internal class Absorb : PokeMove
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
            get { return _instance ?? (_instance = new Absorb()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Absorb()
            : base(
                71,
                "Absorb",
                "Vole-Vie",
                "A nutrient-draining attack. The user’s HP is restored by half the damage taken by the target.",
                "Une attaque qui convertit la moitié des dégâts infligés en PV pour le lanceur.",
                20,
                100,
                DamageClass.Special,
                TypeGrass.Instance
            ) { }
        #endregion
    }
}