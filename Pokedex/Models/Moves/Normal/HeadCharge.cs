using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class HeadCharge : PokeMove
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
            get { return _instance ?? (_instance = new HeadCharge()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private HeadCharge()
            : base(
                543,
                "Head Charge",
                "Peignée",
                "The user charges its head into its target, using its powerful guard hair. This also damages the user a little.",
                "Le lanceur donne un coup avec sa tête couronnée d’une fière crinière. Blesse aussi légèrement le lanceur.",
                120,
                100,
                DamageClass.Physical,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}