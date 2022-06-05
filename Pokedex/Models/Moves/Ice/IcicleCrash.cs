using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ice
{
    internal class IcicleCrash : PokeMove
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
            get { return _instance ?? (_instance = new IcicleCrash()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private IcicleCrash()
            : base(
                556,
                "Icicle Crash",
                "Chute Glace",
                "The user attacks by harshly dropping large icicles onto the target. This may also make the target flinch.",
                "Envoie de gros blocs de glace sur l’ennemi pour lui infliger des dégâts. Peut aussi l’apeurer.",
                85,
                90,
                DamageClass.Physical,
                TypeIce.Instance
            ) { }
        #endregion
    }
}