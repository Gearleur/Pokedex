using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Steel
{
    internal class SunsteelStrike : PokeMove
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
            get { return _instance ?? (_instance = new SunsteelStrike()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SunsteelStrike()
            : base(
                713,
                "Sunsteel Strike",
                "Choc Météore",
                "The user slams into the target with the force of a meteor. This move can be used on the target regardless of its Abilities.",
                "Le lanceur fonce sur la cible à la vitesse d’une météorite. Ignore le talent de l’ennemi.",
                100,
                100,
                DamageClass.Physical,
                TypeSteel.Instance
            ) { }
        #endregion
    }
}