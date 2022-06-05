using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class SparklingAria : PokeMove
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
            get { return _instance ?? (_instance = new SparklingAria()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SparklingAria()
            : base(
                664,
                "Sparkling Aria",
                "Aria de l’Écume",
                "The user bursts into song, emitting many bubbles. Any Pokémon suffering from a burn will be healed by the touch of these bubbles.",
                "Le lanceur émet plusieurs bulles en chantant. Soigne les brûlures des Pokémon touchés par ces bulles.",
                90,
                100,
                DamageClass.Special,
                TypeWater.Instance
            ) { }
        #endregion
    }
}