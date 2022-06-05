using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ghost
{
    internal class ShadowForce : PokeMove
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
            get { return _instance ?? (_instance = new ShadowForce()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private ShadowForce()
            : base(
                467,
                "Shadow Force",
                "Revenant",
                "The user disappears, then strikes the target on the next turn. This move hits even if the target protects itself.",
                "Le lanceur disparaît et frappe l’ennemi au second tour. Fonctionne même si l’ennemi se protège.",
                120,
                100,
                DamageClass.Physical,
                TypeGhost.Instance
            ) { }
        #endregion
    }
}