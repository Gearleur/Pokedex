using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class Dive : PokeMove
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
            get { return _instance ?? (_instance = new Dive()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Dive()
            : base(
                291,
                "Dive",
                "Plongée",
                "Diving on the first turn, the user floats up and attacks on the next turn.",
                "Le lanceur plonge sous l’eau au premier tour et frappe au second.",
                80,
                100,
                DamageClass.Physical,
                TypeWater.Instance
            ) { }
        #endregion
    }
}