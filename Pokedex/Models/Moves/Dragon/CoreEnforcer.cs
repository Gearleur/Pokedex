using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dragon
{
    internal class CoreEnforcer : PokeMove
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
            get { return _instance ?? (_instance = new CoreEnforcer()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private CoreEnforcer()
            : base(
                687,
                "Core Enforcer",
                "Sanction Suprême",
                "If the Pokémon the user has inflicted damage on have already used their moves, this move eliminates the effect of the target’s Ability.",
                "La cible subit des dégâts et, si elle a déjà agi à ce tour, elle perd aussi son talent.",
                100,
                100,
                DamageClass.Special,
                TypeDragon.Instance
            ) { }
        #endregion
    }
}