using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class ShellTrap : PokeMove
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
            get { return _instance ?? (_instance = new ShellTrap()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private ShellTrap()
            : base(
                704,
                "Shell Trap",
                "Carapiège",
                "The user sets a shell trap. If the user is hit by a physical move, the trap will explode and inflict damage on opposing Pokémon.",
                "Pose une carapace piégée. Si l’adversaire utilise une capacité physique, la carapace explose et lui inflige des dégâts.",
                150,
                100,
                DamageClass.Special,
                TypeFire.Instance
            ) { }
        #endregion
    }
}