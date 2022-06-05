using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fairy
{
    internal class FleurCannon : PokeMove
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
            get { return _instance ?? (_instance = new FleurCannon()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FleurCannon()
            : base(
                705,
                "Fleur Cannon",
                "Canon Floral",
                "The user unleashes a strong beam. The attack’s recoil harshly lowers the user’s Sp. Atk stat.",
                "Envoie un rayon laser dévastateur. Baisse beaucoup l’Attaque Spéciale du lanceur.",
                130,
                90,
                DamageClass.Special,
                TypeFairy.Instance
            ) { }
        #endregion
    }
}