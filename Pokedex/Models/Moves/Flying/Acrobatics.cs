using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Flying
{
    internal class Acrobatics : PokeMove
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
            get { return _instance ?? (_instance = new Acrobatics()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Acrobatics()
            : base(
                512,
                "Acrobatics",
                "Acrobatie",
                "The user nimbly strikes the target. If the user is not holding an item, this attack inflicts massive damage.",
                "Attaque agile. Si le lanceur ne tient pas d’objet, l’attaque inflige davantage de dégâts.",
                55,
                100,
                DamageClass.Physical,
                TypeFlying.Instance
            ) { }
        #endregion
    }
}