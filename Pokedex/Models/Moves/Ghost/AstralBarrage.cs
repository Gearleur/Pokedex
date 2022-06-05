using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ghost
{
    internal class AstralBarrage : PokeMove
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
            get { return _instance ?? (_instance = new AstralBarrage()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private AstralBarrage()
            : base(
                825,
                "Astral Barrage",
                "Éclat Spectral",
                "The user attacks by sending a frightful amount of small ghosts at opposing Pokémon.",
                "Le lanceur attaque l’ennemi avec une multitude de petits spectres.",
                120,
                100,
                DamageClass.Special,
                TypeGhost.Instance
            ) { }
        #endregion
    }
}