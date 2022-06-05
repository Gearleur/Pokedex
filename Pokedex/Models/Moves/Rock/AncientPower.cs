using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Rock
{
    internal class AncientPower : PokeMove
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
            get { return _instance ?? (_instance = new AncientPower()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private AncientPower()
            : base(
                246,
                "Ancient Power",
                "Pouvoir Antique",
                "The user attacks with a prehistoric power. This may also raise all the user’s stats at once.",
                "Une attaque préhistorique qui peut augmenter toutes les stats du lanceur d’un seul coup.",
                60,
                100,
                DamageClass.Special,
                TypeRock.Instance
            ) { }
        #endregion
    }
}