using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Bug
{
    internal class BugBuzz : PokeMove
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
            get { return _instance ?? (_instance = new BugBuzz()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private BugBuzz()
            : base(
                405,
                "Bug Buzz",
                "Bourdon",
                "The user generates a damaging sound wave by vibration. This may also lower the target’s Sp. Def stat.",
                "Le lanceur fait vibrer son corps pour lancer une vague sonique. Peut aussi baisser la Défense Spéciale de l’ennemi.",
                90,
                100,
                DamageClass.Special,
                TypeBug.Instance
            ) { }
        #endregion
    }
}