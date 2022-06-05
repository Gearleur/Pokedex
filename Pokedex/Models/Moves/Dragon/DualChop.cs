using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dragon
{
    internal class DualChop : PokeMove
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
            get { return _instance ?? (_instance = new DualChop()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DualChop()
            : base(
                530,
                "Dual Chop",
                "Double Baffe",
                "The user attacks its target by hitting it with brutal strikes. The target is hit twice in a row.",
                "Le lanceur frappe l’ennemi deux fois d’affilée avec les parties les plus robustes de son corps.",
                40,
                90,
                DamageClass.Physical,
                TypeDragon.Instance
            ) { }
        #endregion
    }
}