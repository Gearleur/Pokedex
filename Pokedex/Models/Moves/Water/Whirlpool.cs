using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class Whirlpool : PokeMove
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
            get { return _instance ?? (_instance = new Whirlpool()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Whirlpool()
            : base(
                250,
                "Whirlpool",
                "Siphon",
                "The user traps the target in a violent swirling whirlpool for four to five turns.",
                "Piège l’ennemi dans une trombe d’eau pendant quatre à cinq tours.",
                35,
                85,
                DamageClass.Special,
                TypeWater.Instance
            ) { }
        #endregion
    }
}