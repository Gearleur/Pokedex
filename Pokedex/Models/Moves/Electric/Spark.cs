using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Electric
{
    internal class Spark : PokeMove
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
            get { return _instance ?? (_instance = new Spark()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Spark()
            : base(
                209,
                "Spark",
                "Étincelle",
                "The user throws an electrically charged tackle at the target. This may also leave the target with paralysis.",
                "Lance une charge électrique sur l’ennemi. Peut aussi le paralyser.",
                65,
                100,
                DamageClass.Physical,
                TypeElectric.Instance
            ) { }
        #endregion
    }
}