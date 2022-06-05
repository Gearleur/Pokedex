using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class FlameCharge : PokeMove
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
            get { return _instance ?? (_instance = new FlameCharge()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FlameCharge()
            : base(
                488,
                "Flame Charge",
                "Nitrocharge",
                "Cloaking itself in flame, the user attacks the target. Then, building up more power, the user raises its Speed stat.",
                "Le lanceur s’entoure de flammes pour attaquer l’ennemi. Il se concentre et sa Vitesse augmente.",
                50,
                100,
                DamageClass.Physical,
                TypeFire.Instance
            ) { }
        #endregion
    }
}