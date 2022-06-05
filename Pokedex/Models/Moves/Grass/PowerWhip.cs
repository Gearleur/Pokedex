using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Grass
{
    internal class PowerWhip : PokeMove
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
            get { return _instance ?? (_instance = new PowerWhip()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private PowerWhip()
            : base(
                438,
                "Power Whip",
                "Mégafouet",
                "The user violently whirls its vines, tentacles, or the like to harshly lash the target.",
                "Le lanceur fait virevolter violemment ses lianes ou ses tentacules pour fouetter l’ennemi.",
                120,
                85,
                DamageClass.Physical,
                TypeGrass.Instance
            ) { }
        #endregion
    }
}