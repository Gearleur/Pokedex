using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ice
{
    internal class IcyWind : PokeMove
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
            get { return _instance ?? (_instance = new IcyWind()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private IcyWind()
            : base(
                196,
                "Icy Wind",
                "Vent Glace",
                "The user attacks with a gust of chilled air. This also lowers opposing Pokémon’s Speed stats.",
                "Une bourrasque de vent froid blesse l’ennemi. Réduit aussi sa Vitesse.",
                55,
                95,
                DamageClass.Special,
                TypeIce.Instance
            ) { }
        #endregion
    }
}