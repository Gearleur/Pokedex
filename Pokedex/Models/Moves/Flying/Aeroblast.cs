using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Flying
{
    internal class Aeroblast : PokeMove
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
            get { return _instance ?? (_instance = new Aeroblast()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Aeroblast()
            : base(
                177,
                "Aeroblast",
                "Aéroblast",
                "A vortex of air is shot at the target to inflict damage. Critical hits land more easily.",
                "Le lanceur projette une tornade sur l’ennemi pour infliger des dégâts. Taux de critiques élevé.",
                100,
                95,
                DamageClass.Special,
                TypeFlying.Instance
            ) { }
        #endregion
    }
}