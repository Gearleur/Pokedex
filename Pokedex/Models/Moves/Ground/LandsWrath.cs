using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ground
{
    internal class LandsWrath : PokeMove
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
            get { return _instance ?? (_instance = new LandsWrath()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private LandsWrath()
            : base(
                616,
                "Land’s Wrath",
                "Force Chtonienne",
                "The user gathers the energy of the land and focuses that power on opposing Pokémon to damage them.",
                "Utilise la puissance du sol et la concentre sur l’ennemi pour infliger des dégâts.",
                90,
                100,
                DamageClass.Physical,
                TypeGround.Instance
            ) { }
        #endregion
    }
}