using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Bug
{
    internal class Lunge : PokeMove
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
            get { return _instance ?? (_instance = new Lunge()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Lunge()
            : base(
                679,
                "Lunge",
                "Furie-Bond",
                "The user makes a lunge at the target, attacking with full force. This also lowers the target’s Attack stat.",
                "Le lanceur se jette sur la cible de toutes ses forces pour lui infliger des dégâts et baisser son Attaque.",
                80,
                100,
                DamageClass.Physical,
                TypeBug.Instance
            ) { }
        #endregion
    }
}