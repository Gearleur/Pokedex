using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Steel
{
    internal class DoomDesire : PokeMove
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
            get { return _instance ?? (_instance = new DoomDesire()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DoomDesire()
            : base(
                353,
                "Doom Desire",
                "Vœu Destructeur",
                "Two turns after this move is used, a concentrated bundle of light blasts the target.",
                "Le lanceur génère une sphère lumineuse qu’il projette sur l’ennemi deux tours plus tard.",
                140,
                100,
                DamageClass.Special,
                TypeSteel.Instance
            ) { }
        #endregion
    }
}