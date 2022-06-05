using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ice
{
    internal class IcicleSpear : PokeMove
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
            get { return _instance ?? (_instance = new IcicleSpear()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private IcicleSpear()
            : base(
                333,
                "Icicle Spear",
                "Stalactite",
                "The user launches sharp icicles at the target two to five times in a row.",
                "Le lanceur jette des pics de glace sur l’ennemi, de deux à cinq fois de suite.",
                25,
                100,
                DamageClass.Physical,
                TypeIce.Instance
            ) { }
        #endregion
    }
}