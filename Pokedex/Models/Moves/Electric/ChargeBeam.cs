using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Electric
{
    internal class ChargeBeam : PokeMove
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
            get { return _instance ?? (_instance = new ChargeBeam()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private ChargeBeam()
            : base(
                451,
                "Charge Beam",
                "Rayon Chargé",
                "The user attacks the target with an electric charge. The user may use any remaining electricity to raise its Sp. Atk stat.",
                "Le lanceur tire un rayon chargé d’électricité. Peut aussi augmenter son Attaque Spéciale.",
                50,
                90,
                DamageClass.Special,
                TypeElectric.Instance
            ) { }
        #endregion
    }
}