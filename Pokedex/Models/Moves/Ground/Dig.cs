using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ground
{
    internal class Dig : PokeMove
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
            get { return _instance ?? (_instance = new Dig()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Dig()
            : base(
                91,
                "Dig",
                "Tunnel",
                "The user burrows into the ground, then attacks on the next turn.",
                "Le lanceur creuse au premier tour et frappe au second.",
                80,
                100,
                DamageClass.Physical,
                TypeGround.Instance
            ) { }
        #endregion
    }
}