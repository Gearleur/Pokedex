using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class SteamEruption : PokeMove
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
            get { return _instance ?? (_instance = new SteamEruption()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SteamEruption()
            : base(
                592,
                "Steam Eruption",
                "Jet de Vapeur",
                "The user immerses the target in superheated steam. This may also leave the target with a burn.",
                "Plonge l’ennemi dans une chaleur étouffante. Peut le brûler.",
                110,
                95,
                DamageClass.Special,
                TypeWater.Instance
            ) { }
        #endregion
    }
}