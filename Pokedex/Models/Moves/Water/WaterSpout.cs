using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class WaterSpout : PokeMove
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
            get { return _instance ?? (_instance = new WaterSpout()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private WaterSpout()
            : base(
                323,
                "Water Spout",
                "Giclédo",
                "The user spouts water to damage opposing Pokémon. The lower the user’s HP, the lower the move’s power.",
                "Le lanceur attaque avec un jet d’eau. Moins il a de PV et moins l’attaque est puissante.",
                150,
                100,
                DamageClass.Special,
                TypeWater.Instance
            ) { }
        #endregion
    }
}