using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class Judgment : PokeMove
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
            get { return _instance ?? (_instance = new Judgment()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Judgment()
            : base(
                449,
                "Judgment",
                "Jugement",
                "The user releases countless shots of light at the target. This move’s type varies depending on the kind of Plate the user is holding.",
                "Le lanceur libère une myriade de rayons de lumière. Le type varie selon la Plaque que tient le lanceur.",
                100,
                100,
                DamageClass.Special,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}