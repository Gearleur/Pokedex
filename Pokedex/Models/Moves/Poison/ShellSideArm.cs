using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Poison
{
    internal class ShellSideArm : PokeMove
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
            get { return _instance ?? (_instance = new ShellSideArm()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private ShellSideArm()
            : base(
                801,
                "Shell Side Arm",
                "Kokiyarme",
                "This move inflicts physical or special damage, whichever will be more effective. This may also poison the target.",
                "Une attaque physique ou spéciale, en fonction de ce qui est le plus efficace contre la cible. Peut aussi empoisonner.",
                90,
                100,
                DamageClass.Special,
                TypePoison.Instance
            ) { }
        #endregion
    }
}