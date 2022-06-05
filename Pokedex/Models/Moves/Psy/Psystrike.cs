using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Psy
{
    internal class Psystrike : PokeMove
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
            get { return _instance ?? (_instance = new Psystrike()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Psystrike()
            : base(
                540,
                "Psystrike",
                "Frappe Psy",
                "The user materializes an odd psychic wave to attack the target. This attack does physical damage.",
                "Le lanceur matérialise des ondes mystérieuses qu’il projette sur l’ennemi. Inflige des dégâts physiques.",
                100,
                100,
                DamageClass.Special,
                TypePsy.Instance
            ) { }
        #endregion
    }
}