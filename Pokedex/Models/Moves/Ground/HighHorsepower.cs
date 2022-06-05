using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ground
{
    internal class HighHorsepower : PokeMove
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
            get { return _instance ?? (_instance = new HighHorsepower()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private HighHorsepower()
            : base(
                667,
                "High Horsepower",
                "Cavalerie Lourde",
                "The user fiercely attacks the target using its entire body.",
                "Le lanceur attaque violemment en utilisant tout son poids.",
                95,
                95,
                DamageClass.Physical,
                TypeGround.Instance
            ) { }
        #endregion
    }
}