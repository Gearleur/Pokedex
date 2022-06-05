using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Bug
{
    internal class AttackOrder : PokeMove
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
            get { return _instance ?? (_instance = new AttackOrder()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private AttackOrder()
            : base(
                454,
                "Attack Order",
                "Appel Attaque",
                "The user calls out its underlings to pummel the target. Critical hits land more easily.",
                "Le lanceur appelle ses sous-fifres pour frapper l’ennemi. Taux de critiques élevé.",
                90,
                100,
                DamageClass.Physical,
                TypeBug.Instance
            ) { }
        #endregion
    }
}