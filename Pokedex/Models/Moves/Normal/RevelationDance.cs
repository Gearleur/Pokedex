using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class RevelationDance : PokeMove
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
            get { return _instance ?? (_instance = new RevelationDance()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private RevelationDance()
            : base(
                686,
                "Revelation Dance",
                "Danse Éveil",
                "The user attacks the target by dancing very hard. The user’s type determines the type of this move.",
                "Le lanceur attaque en dansant avec enthousiasme. Le type de la capacité est le même que celui du lanceur.",
                90,
                100,
                DamageClass.Special,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}