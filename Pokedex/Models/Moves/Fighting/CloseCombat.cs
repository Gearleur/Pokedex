using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fighting
{
    internal class CloseCombat : PokeMove
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
            get { return _instance ?? (_instance = new CloseCombat()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private CloseCombat()
            : base(
                370,
                "Close Combat",
                "Close Combat",
                "The user fights the target up close without guarding itself. This also lowers the user’s Defense and Sp. Def stats.",
                "Le lanceur combat au corps à corps sans se protéger. Baisse aussi sa Défense et sa Défense Spéciale.",
                120,
                100,
                DamageClass.Physical,
                TypeFighting.Instance
            ) { }
        #endregion
    }
}