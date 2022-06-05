using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Psy
{
    internal class PhotonGeyser : PokeMove
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
            get { return _instance ?? (_instance = new PhotonGeyser()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private PhotonGeyser()
            : base(
                722,
                "Photon Geyser",
                "Photo-Geyser",
                "The user attacks a target with a pillar of light. This move inflicts Attack or Sp. Atk damage—whichever stat is higher for the user.",
                "Le lanceur fait jaillir un pilier de lumière. Compare l’Attaque et l’Attaque Spéciale, et utilise celle qui infligera le plus de dégâts.",
                100,
                100,
                DamageClass.Special,
                TypePsy.Instance
            ) { }
        #endregion
    }
}