using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dragon
{
    internal class ScaleShot : PokeMove
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
            get { return _instance ?? (_instance = new ScaleShot()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private ScaleShot()
            : base(
                799,
                "Scale Shot",
                "Rafale Écailles",
                "The user attacks by shooting scales two to five times in a row. This move boosts the user’s Speed stat but lowers its Defense stat.",
                "Le lanceur projette des écailles sur la cible de deux à cinq fois d’affilée. Augmente la Vitesse, mais diminue la Défense.",
                25,
                90,
                DamageClass.Physical,
                TypeDragon.Instance
            ) { }
        #endregion
    }
}