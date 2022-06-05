using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ghost
{
    internal class Hex : PokeMove
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
            get { return _instance ?? (_instance = new Hex()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Hex()
            : base(
                506,
                "Hex",
                "Châtiment",
                "This relentless attack does massive damage to a target affected by status conditions.",
                "Attaque acharnée qui cause davantage de dégâts à l’ennemi s’il a un problème de statut.",
                65,
                100,
                DamageClass.Special,
                TypeGhost.Instance
            ) { }
        #endregion
    }
}