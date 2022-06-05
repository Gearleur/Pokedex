using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Flying
{
    internal class Fly : PokeMove
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
            get { return _instance ?? (_instance = new Fly()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Fly()
            : base(
                19,
                "Fly",
                "Vol",
                "The user flies up into the sky and then strikes its target on the next turn.",
                "Le lanceur s’envole au premier tour et frappe au second.",
                90,
                95,
                DamageClass.Physical,
                TypeFlying.Instance
            ) { }
        #endregion
    }
}