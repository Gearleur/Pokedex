using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class Waterfall : PokeMove
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
            get { return _instance ?? (_instance = new Waterfall()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Waterfall()
            : base(
                127,
                "Waterfall",
                "Cascade",
                "The user charges at the target and may make it flinch.",
                "Le lanceur charge l’ennemi à une vitesse remarquable, ce qui peut l’apeurer.",
                80,
                100,
                DamageClass.Physical,
                TypeWater.Instance
            ) { }
        #endregion
    }
}