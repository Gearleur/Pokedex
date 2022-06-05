using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fairy
{
    internal class FairyWind : PokeMove
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
            get { return _instance ?? (_instance = new FairyWind()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FairyWind()
            : base(
                584,
                "Fairy Wind",
                "Vent Féérique",
                "The user stirs up a fairy wind and strikes the target with it.",
                "Déchaîne un vent magique qui cingle l’ennemi.",
                40,
                100,
                DamageClass.Special,
                TypeFairy.Instance
            ) { }
        #endregion
    }
}