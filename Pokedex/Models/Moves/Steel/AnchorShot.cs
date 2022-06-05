using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Steel
{
    internal class AnchorShot : PokeMove
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
            get { return _instance ?? (_instance = new AnchorShot()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private AnchorShot()
            : base(
                677,
                "Anchor Shot",
                "Ancrage",
                "The user entangles the target with its anchor chain while attacking. The target becomes unable to flee.",
                "Le lanceur jette son ancre sur la cible pour l’attaquer. Une fois accrochée, elle l’empêche de s’enfuir.",
                80,
                100,
                DamageClass.Physical,
                TypeSteel.Instance
            ) { }
        #endregion
    }
}