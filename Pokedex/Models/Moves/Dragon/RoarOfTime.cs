using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dragon
{
    internal class RoarOfTime : PokeMove
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
            get { return _instance ?? (_instance = new RoarOfTime()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private RoarOfTime()
            : base(
                459,
                "Roar of Time",
                "Hurle-Temps",
                "The user blasts the target with power that distorts even time. The user can’t move on the next turn.",
                "Le lanceur frappe si fort qu’il affecte le cours du temps. Il se repose au tour suivant.",
                150,
                90,
                DamageClass.Special,
                TypeDragon.Instance
            ) { }
        #endregion
    }
}