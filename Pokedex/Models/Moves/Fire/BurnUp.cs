using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class BurnUp : PokeMove
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
            get { return _instance ?? (_instance = new BurnUp()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private BurnUp()
            : base(
                682,
                "Burn Up",
                "Flamme Ultime",
                "To inflict massive damage, the user burns itself out. After using this move, the user will no longer be Fire type.",
                "Le Pokémon se consume et les flammes de son corps infligent des dégâts élevés à la cible. Le lanceur perd le type Feu.",
                130,
                100,
                DamageClass.Special,
                TypeFire.Instance
            ) { }
        #endregion
    }
}