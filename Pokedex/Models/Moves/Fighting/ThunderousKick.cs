using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fighting
{
    internal class ThunderousKick : PokeMove
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
            get { return _instance ?? (_instance = new ThunderousKick()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private ThunderousKick()
            : base(
                823,
                "Thunderous Kick",
                "Coup Fulgurant",
                "The user overwhelms the target with lightning-like movement before delivering a kick. This also lowers the target’s Defense stat.",
                "Le lanceur assène un coup de pied à la cible à la vitesse de l’éclair. Baisse aussi la Défense de la cible.",
                90,
                100,
                DamageClass.Physical,
                TypeFighting.Instance
            ) { }
        #endregion
    }
}