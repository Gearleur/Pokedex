using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Flying
{
    internal class Pluck : PokeMove
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
            get { return _instance ?? (_instance = new Pluck()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Pluck()
            : base(
                365,
                "Pluck",
                "Picore",
                "The user pecks the target. If the target is holding a Berry, the user eats it and gains its effect.",
                "Le lanceur picore la cible. Si cette dernière tient une Baie, le lanceur la mange et profite de ses effets.",
                60,
                100,
                DamageClass.Physical,
                TypeFlying.Instance
            ) { }
        #endregion
    }
}