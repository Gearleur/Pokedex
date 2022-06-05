using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class BlazeKick : PokeMove
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
            get { return _instance ?? (_instance = new BlazeKick()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private BlazeKick()
            : base(
                299,
                "Blaze Kick",
                "Pied Brûleur",
                "The user launches a kick that lands a critical hit more easily. This may also leave the target with a burn.",
                "Le lanceur envoie un coup de pied au taux de critiques élevé. Peut aussi brûler la cible.",
                85,
                90,
                DamageClass.Physical,
                TypeFire.Instance
            ) { }
        #endregion
    }
}