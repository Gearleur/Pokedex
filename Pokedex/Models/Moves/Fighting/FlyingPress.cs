using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fighting
{
    internal class FlyingPress : PokeMove
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
            get { return _instance ?? (_instance = new FlyingPress()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FlyingPress()
            : base(
                560,
                "Flying Press",
                "Flying Press",
                "The user dives down onto the target from the sky. This move is Fighting and Flying type simultaneously.",
                "Une attaque en piqué depuis le ciel, à la fois de type Combat et de type Vol.",
                100,
                95,
                DamageClass.Physical,
                TypeFighting.Instance
            ) { }
        #endregion
    }
}