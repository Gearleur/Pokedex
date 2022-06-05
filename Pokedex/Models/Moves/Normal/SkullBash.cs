using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class SkullBash : PokeMove
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
            get { return _instance ?? (_instance = new SkullBash()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SkullBash()
            : base(
                130,
                "Skull Bash",
                "Coud’Krâne",
                "The user tucks in its head to raise its Defense stat on the first turn, then rams the target on the next turn.",
                "Le lanceur baisse la tête pour augmenter sa Défense au premier tour et percuter l’ennemi au second.",
                130,
                100,
                DamageClass.Physical,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}