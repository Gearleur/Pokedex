using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class Inferno : PokeMove
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
            get { return _instance ?? (_instance = new Inferno()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Inferno()
            : base(
                517,
                "Inferno",
                "Feu d’Enfer",
                "The user attacks by engulfing the target in an intense fire. This leaves the target with a burn.",
                "L’ennemi est entouré d’un torrent de flammes ardentes qui le brûlent.",
                100,
                50,
                DamageClass.Special,
                TypeFire.Instance
            ) { }
        #endregion
    }
}