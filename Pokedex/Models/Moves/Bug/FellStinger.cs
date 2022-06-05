using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Bug
{
    internal class FellStinger : PokeMove
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
            get { return _instance ?? (_instance = new FellStinger()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FellStinger()
            : base(
                565,
                "Fell Stinger",
                "Dard Mortel",
                "When the user knocks out a target with this move, the user’s Attack stat rises drastically.",
                "Augmente énormément l’Attaque du lanceur si un ennemi est mis K.O. avec cette capacité.",
                50,
                100,
                DamageClass.Physical,
                TypeBug.Instance
            ) { }
        #endregion
    }
}