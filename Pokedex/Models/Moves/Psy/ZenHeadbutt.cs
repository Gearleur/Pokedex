using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Psy
{
    internal class ZenHeadbutt : PokeMove
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
            get { return _instance ?? (_instance = new ZenHeadbutt()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private ZenHeadbutt()
            : base(
                428,
                "Zen Headbutt",
                "Psykoud’Boul",
                "The user focuses its willpower to its head and attacks the target. This may also make the target flinch.",
                "Le lanceur concentre sa volonté et donne un coup de tête. Peut aussi apeurer l’ennemi.",
                80,
                90,
                DamageClass.Physical,
                TypePsy.Instance
            ) { }
        #endregion
    }
}