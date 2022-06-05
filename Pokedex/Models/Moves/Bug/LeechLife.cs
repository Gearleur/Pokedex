using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Bug
{
    internal class LeechLife : PokeMove
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
            get { return _instance ?? (_instance = new LeechLife()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private LeechLife()
            : base(
                141,
                "Leech Life",
                "Vampirisme",
                "The user drains the target’s blood. The user’s HP is restored by half the damage taken by the target.",
                "Une attaque qui aspire le sang de l’ennemi. La moitié des dégâts sont convertis en PV pour le lanceur.",
                80,
                100,
                DamageClass.Physical,
                TypeBug.Instance
            ) { }
        #endregion
    }
}