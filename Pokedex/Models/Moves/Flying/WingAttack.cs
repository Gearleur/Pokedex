using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Flying
{
    internal class WingAttack : PokeMove
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
            get { return _instance ?? (_instance = new WingAttack()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private WingAttack()
            : base(
                17,
                "Wing Attack",
                "Cru-Ailes",
                "The target is struck with large, imposing wings spread wide to inflict damage.",
                "L’ennemi est frappé par de larges ailes déployées pour infliger des dégâts.",
                60,
                100,
                DamageClass.Physical,
                TypeFlying.Instance
            ) { }
        #endregion
    }
}