using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ground
{
    internal class PrecipiceBlades : PokeMove
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
            get { return _instance ?? (_instance = new PrecipiceBlades()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private PrecipiceBlades()
            : base(
                619,
                "Precipice Blades",
                "Lame Pangéenne",
                "The user attacks opposing Pokémon by manifesting the power of the land in fearsome blades of stone.",
                "Le Pokémon transforme la puissance de la terre et attaque la cible avec une lame acérée.",
                120,
                85,
                DamageClass.Physical,
                TypeGround.Instance
            ) { }
        #endregion
    }
}