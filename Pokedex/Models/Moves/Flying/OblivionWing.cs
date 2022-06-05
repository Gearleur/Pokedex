using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Flying
{
    internal class OblivionWing : PokeMove
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
            get { return _instance ?? (_instance = new OblivionWing()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private OblivionWing()
            : base(
                613,
                "Oblivion Wing",
                "Mort’Ailes",
                "The user absorbs its target’s HP. The user’s HP is restored by over half of the damage taken by the target.",
                "Vole l’énergie de la cible. Rend au lanceur un nombre de PV supérieur ou égal à la moitié des dégâts infligés.",
                80,
                100,
                DamageClass.Special,
                TypeFlying.Instance
            ) { }
        #endregion
    }
}