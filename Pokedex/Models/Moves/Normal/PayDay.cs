using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class PayDay : PokeMove
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
            get { return _instance ?? (_instance = new PayDay()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private PayDay()
            : base(
                6,
                "Pay Day",
                "Jackpot",
                "Numerous coins are hurled at the target to inflict damage. Money is earned after the battle.",
                "Des pièces sont lancées sur l’ennemi. Permet d’obtenir de l’argent à la fin du combat.",
                40,
                100,
                DamageClass.Physical,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}