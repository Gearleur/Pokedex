using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class TriAttack : PokeMove
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
            get { return _instance ?? (_instance = new TriAttack()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private TriAttack()
            : base(
                161,
                "Tri Attack",
                "Triplattaque",
                "The user strikes with a simultaneous three-beam attack. This may also burn, freeze, or paralyze the target.",
                "Le lanceur envoie trois boules d’énergie simultanément. Peut aussi paralyser, brûler ou geler l’ennemi.",
                80,
                100,
                DamageClass.Special,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}