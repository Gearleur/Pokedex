using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class Brine : PokeMove
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
            get { return _instance ?? (_instance = new Brine()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Brine()
            : base(
                362,
                "Brine",
                "Saumure",
                "If the target’s HP is half or less, this attack will hit with double the power.",
                "Cette attaque est deux fois plus puissante lorsque l’ennemi a moins de la moitié de ses PV.",
                65,
                100,
                DamageClass.Special,
                TypeWater.Instance
            ) { }
        #endregion
    }
}