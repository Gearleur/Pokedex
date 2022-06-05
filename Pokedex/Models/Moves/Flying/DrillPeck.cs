using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Flying
{
    internal class DrillPeck : PokeMove
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
            get { return _instance ?? (_instance = new DrillPeck()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DrillPeck()
            : base(
                65,
                "Drill Peck",
                "Bec Vrille",
                "A corkscrewing attack that strikes the target with a sharp beak acting as a drill.",
                "Une attaque utilisant le bec comme une perceuse.",
                80,
                100,
                DamageClass.Physical,
                TypeFlying.Instance
            ) { }
        #endregion
    }
}