using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Electric
{
    internal class ParabolicCharge : PokeMove
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
            get { return _instance ?? (_instance = new ParabolicCharge()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private ParabolicCharge()
            : base(
                570,
                "Parabolic Charge",
                "Parabocharge",
                "The user attacks everything around it. The user’s HP is restored by half the damage taken by those hit.",
                "Inflige des dégâts à tous les Pokémon autour du lanceur. Il récupère en PV la moitié des dégâts infligés.",
                65,
                100,
                DamageClass.Special,
                TypeElectric.Instance
            ) { }
        #endregion
    }
}