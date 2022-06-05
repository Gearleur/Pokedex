using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class DoubleHit : PokeMove
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
            get { return _instance ?? (_instance = new DoubleHit()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DoubleHit()
            : base(
                458,
                "Double Hit",
                "Coup Double",
                "The user slams the target with a long tail, vines, or a tentacle. The target is hit twice in a row.",
                "Le lanceur frappe l’ennemi deux fois d’affilée à l’aide de sa queue, de lianes ou d’un autre membre.",
                35,
                90,
                DamageClass.Physical,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}