using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class FlameWheel : PokeMove
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
            get { return _instance ?? (_instance = new FlameWheel()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FlameWheel()
            : base(
                172,
                "Flame Wheel",
                "Roue de Feu",
                "The user cloaks itself in fire and charges at the target. This may also leave the target with a burn.",
                "Le lanceur s’entoure de feu et charge l’ennemi. Peut aussi le brûler.",
                60,
                100,
                DamageClass.Physical,
                TypeFire.Instance
            ) { }
        #endregion
    }
}