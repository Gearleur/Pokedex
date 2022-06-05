using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Electric
{
    internal class ZingZap : PokeMove
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
            get { return _instance ?? (_instance = new ZingZap()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private ZingZap()
            : base(
                716,
                "Zing Zap",
                "Électrikipik",
                "A strong electric blast crashes down on the target, giving it an electric shock. This may also make the target flinch.",
                "Le lanceur fonce sur la cible et lui envoie un puissant choc électrique. Peut aussi l’effrayer.",
                80,
                100,
                DamageClass.Physical,
                TypeElectric.Instance
            ) { }
        #endregion
    }
}