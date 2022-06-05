using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Rock
{
    internal class PowerGem : PokeMove
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
            get { return _instance ?? (_instance = new PowerGem()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private PowerGem()
            : base(
                408,
                "Power Gem",
                "Rayon Gemme",
                "The user attacks with a ray of light that sparkles as if it were made of gemstones.",
                "Le lanceur attaque avec un rayon de lumière qui scintille comme s’il était composé de gemmes.",
                80,
                100,
                DamageClass.Special,
                TypeRock.Instance
            ) { }
        #endregion
    }
}