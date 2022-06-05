using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dragon
{
    internal class DragonClaw : PokeMove
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
            get { return _instance ?? (_instance = new DragonClaw()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DragonClaw()
            : base(
                337,
                "Dragon Claw",
                "Draco-Griffe",
                "The user slashes the target with huge sharp claws.",
                "Le lanceur lacère l’ennemi de ses grandes griffes aiguisées.",
                80,
                100,
                DamageClass.Physical,
                TypeDragon.Instance
            ) { }
        #endregion
    }
}