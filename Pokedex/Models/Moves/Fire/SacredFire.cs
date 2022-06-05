using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class SacredFire : PokeMove
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
            get { return _instance ?? (_instance = new SacredFire()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SacredFire()
            : base(
                221,
                "Sacred Fire",
                "Feu Sacré",
                "The target is razed with a mystical fire of great intensity. This may also leave the target with a burn.",
                "Le lanceur génère un feu mystique d’une intensité redoutable pour attaquer l’ennemi. Peut aussi le brûler.",
                100,
                95,
                DamageClass.Physical,
                TypeFire.Instance
            ) { }
        #endregion
    }
}