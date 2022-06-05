using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fairy
{
    internal class SpiritBreak : PokeMove
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
            get { return _instance ?? (_instance = new SpiritBreak()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SpiritBreak()
            : base(
                789,
                "Spirit Break",
                "Choc Émotionnel",
                "The user attacks the target with so much force that it could break the target’s spirit. This also lowers the target’s Sp. Atk stat.",
                "Le lanceur attaque son adversaire avec une telle force que ce dernier peut s’en retrouver profondément troublé. Baisse l’Attaque Spéciale de la cible.",
                75,
                100,
                DamageClass.Physical,
                TypeFairy.Instance
            ) { }
        #endregion
    }
}