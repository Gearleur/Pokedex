using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class FalseSwipe : PokeMove
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
            get { return _instance ?? (_instance = new FalseSwipe()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FalseSwipe()
            : base(
                206,
                "False Swipe",
                "Faux-Chage",
                "A restrained attack that prevents the target from fainting. The target is left with at least 1 HP.",
                "Le lanceur retient ses coups pour que l’ennemi garde au moins 1 PV et ne tombe pas K.O.",
                40,
                100,
                DamageClass.Physical,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}