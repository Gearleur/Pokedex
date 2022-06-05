using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fighting
{
    internal class FocusPunch : PokeMove
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
            get { return _instance ?? (_instance = new FocusPunch()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FocusPunch()
            : base(
                264,
                "Focus Punch",
                "Mitra-Poing",
                "The user focuses its mind before launching a punch. This move fails if the user is hit before it is used.",
                "Le lanceur se concentre avant d’attaquer. Échoue s’il est touché avant d’avoir frappé.",
                150,
                100,
                DamageClass.Physical,
                TypeFighting.Instance
            ) { }
        #endregion
    }
}