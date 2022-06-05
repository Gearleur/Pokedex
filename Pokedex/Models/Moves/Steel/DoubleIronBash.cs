using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Steel
{
    internal class DoubleIronBash : PokeMove
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
            get { return _instance ?? (_instance = new DoubleIronBash()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DoubleIronBash()
            : base(
                742,
                "Double Iron Bash",
                "Écrous d’Poing",
                "The user rotates, centering the hex nut in its chest, and then strikes with its arms twice in a row. This may also make the target flinch.",
                "Le lanceur fait pivoter l’écrou de sa poitrine deux fois d’affilée pour frapper l’adversaire avec ses bras. Peut apeurer l’ennemi.",
                60,
                100,
                DamageClass.Physical,
                TypeSteel.Instance
            ) { }
        #endregion
    }
}