using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fighting
{
    internal class HammerArm : PokeMove
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
            get { return _instance ?? (_instance = new HammerArm()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private HammerArm()
            : base(
                359,
                "Hammer Arm",
                "Marto-Poing",
                "The user swings and hits with its strong, heavy fist. It lowers the user’s Speed, however.",
                "Le lanceur donne un puissant coup de poing à l’ennemi. Réduit la Vitesse du lanceur.",
                100,
                90,
                DamageClass.Physical,
                TypeFighting.Instance
            ) { }
        #endregion
    }
}