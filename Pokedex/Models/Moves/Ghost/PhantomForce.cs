using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ghost
{
    internal class PhantomForce : PokeMove
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
            get { return _instance ?? (_instance = new PhantomForce()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private PhantomForce()
            : base(
                566,
                "Phantom Force",
                "Hantise",
                "The user vanishes somewhere, then strikes the target on the next turn. This move hits even if the target protects itself.",
                "Le lanceur disparaît au premier tour et frappe au second. Cette attaque passe outre les protections.",
                90,
                100,
                DamageClass.Physical,
                TypeGhost.Instance
            ) { }
        #endregion
    }
}