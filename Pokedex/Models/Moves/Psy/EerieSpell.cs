using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Psy
{
    internal class EerieSpell : PokeMove
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
            get { return _instance ?? (_instance = new EerieSpell()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private EerieSpell()
            : base(
                826,
                "Eerie Spell",
                "Sort Sinistre",
                "The user attacks with its tremendous psychic power. This also removes 3 PP from the target’s last move.",
                "Le lanceur attaque avec de puissants pouvoirs psychiques et retire 3 PP de la dernière capacité de l’ennemi.",
                80,
                100,
                DamageClass.Special,
                TypePsy.Instance
            ) { }
        #endregion
    }
}