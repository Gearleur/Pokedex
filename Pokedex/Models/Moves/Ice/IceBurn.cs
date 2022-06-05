using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ice
{
    internal class IceBurn : PokeMove
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
            get { return _instance ?? (_instance = new IceBurn()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private IceBurn()
            : base(
                554,
                "Ice Burn",
                "Feu Glacé",
                "On the second turn, an ultracold, freezing wind surrounds the target. This may leave the target with a burn.",
                "Au second tour, le lanceur projette un souffle de vent glacial dévastateur sur l’ennemi. Peut aussi le brûler.",
                140,
                90,
                DamageClass.Special,
                TypeIce.Instance
            ) { }
        #endregion
    }
}