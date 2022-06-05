using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fairy
{
    internal class DrainingKiss : PokeMove
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
            get { return _instance ?? (_instance = new DrainingKiss()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DrainingKiss()
            : base(
                577,
                "Draining Kiss",
                "Vampibaiser",
                "The user steals the target’s HP with a kiss. The user’s HP is restored by over half of the damage taken by the target.",
                "Aspire la force vitale de l’ennemi par un baiser. Rend au lanceur un nombre de PV supérieur ou égal à la moitié des dégâts infligés.",
                50,
                100,
                DamageClass.Special,
                TypeFairy.Instance
            ) { }
        #endregion
    }
}