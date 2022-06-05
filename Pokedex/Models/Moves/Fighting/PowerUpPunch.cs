using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fighting
{
    internal class PowerUpPunch : PokeMove
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
            get { return _instance ?? (_instance = new PowerUpPunch()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private PowerUpPunch()
            : base(
                612,
                "Power-Up Punch",
                "Poing Boost",
                "Striking opponents over and over makes the user’s fists harder. Hitting a target raises the Attack stat.",
                "À force de frapper, les poings deviennent plus durs. Augmente l’Attaque du lanceur si l’ennemi est touché.",
                40,
                100,
                DamageClass.Physical,
                TypeFighting.Instance
            ) { }
        #endregion
    }
}