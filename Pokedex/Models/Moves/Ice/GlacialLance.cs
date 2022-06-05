using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ice
{
    internal class GlacialLance : PokeMove
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
            get { return _instance ?? (_instance = new GlacialLance()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private GlacialLance()
            : base(
                824,
                "Glacial Lance",
                "Lance de Glace",
                "The user attacks by hurling a blizzard-cloaked icicle lance at opposing Pokémon.",
                "Le lanceur attaque l’ennemi avec une lance de glace entourée d’un blizzard.",
                130,
                100,
                DamageClass.Physical,
                TypeIce.Instance
            ) { }
        #endregion
    }
}