using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Steel
{
    internal class MetalClaw : PokeMove
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
            get { return _instance ?? (_instance = new MetalClaw()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private MetalClaw()
            : base(
                232,
                "Metal Claw",
                "Griffe Acier",
                "The target is raked with steel claws. This may also raise the user’s Attack stat.",
                "Attaque avec des griffes d’acier. Peut aussi augmenter l’Attaque du lanceur.",
                50,
                95,
                DamageClass.Physical,
                TypeSteel.Instance
            ) { }
        #endregion
    }
}