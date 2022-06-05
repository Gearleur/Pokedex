using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Flying
{
    internal class Chatter : PokeMove
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
            get { return _instance ?? (_instance = new Chatter()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Chatter()
            : base(
                448,
                "Chatter",
                "Babil",
                "The user attacks the target with sound waves of deafening chatter. This confuses the target.",
                "Attaque avec les ondes sonores assourdissantes qu’il émet en bavardant. Rend l’ennemi confus.",
                65,
                100,
                DamageClass.Special,
                TypeFlying.Instance
            ) { }
        #endregion
    }
}