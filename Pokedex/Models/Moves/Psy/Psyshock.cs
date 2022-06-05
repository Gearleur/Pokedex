using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Psy
{
    internal class Psyshock : PokeMove
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
            get { return _instance ?? (_instance = new Psyshock()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Psyshock()
            : base(
                473,
                "Psyshock",
                "Choc Psy",
                "The user materializes an odd psychic wave to attack the target. This attack does physical damage.",
                "Le lanceur matérialise des ondes mystérieuses qu’il projette sur l’ennemi. Inflige des dégâts physiques.",
                80,
                100,
                DamageClass.Special,
                TypePsy.Instance
            ) { }
        #endregion
    }
}