using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class FlareBlitz : PokeMove
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
            get { return _instance ?? (_instance = new FlareBlitz()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FlareBlitz()
            : base(
                394,
                "Flare Blitz",
                "Boutefeu",
                "The user cloaks itself in fire and charges the target. This also damages the user quite a lot. This attack may leave the target with a burn.",
                "Le lanceur s’embrase avant de charger l’ennemi. Le choc blesse aussi gravement le lanceur. Peut brûler l’ennemi.",
                120,
                100,
                DamageClass.Physical,
                TypeFire.Instance
            ) { }
        #endregion
    }
}