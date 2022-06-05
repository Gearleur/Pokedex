using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Flying
{
    internal class SkyAttack : PokeMove
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
            get { return _instance ?? (_instance = new SkyAttack()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SkyAttack()
            : base(
                143,
                "Sky Attack",
                "Piqué",
                "A second-turn attack move where critical hits land more easily. This may also make the target flinch.",
                "Une attaque en deux tours au taux de critiques élevé. Peut aussi apeurer l’ennemi.",
                140,
                90,
                DamageClass.Physical,
                TypeFlying.Instance
            ) { }
        #endregion
    }
}