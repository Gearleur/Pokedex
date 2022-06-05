using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Rock
{
    internal class RockSlide : PokeMove
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
            get { return _instance ?? (_instance = new RockSlide()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private RockSlide()
            : base(
                157,
                "Rock Slide",
                "Éboulement",
                "Large boulders are hurled at opposing Pokémon to inflict damage. This may also make the opposing Pokémon flinch.",
                "Envoie de gros rochers sur l’ennemi pour infliger des dégâts. Peut aussi l’apeurer.",
                75,
                90,
                DamageClass.Physical,
                TypeRock.Instance
            ) { }
        #endregion
    }
}