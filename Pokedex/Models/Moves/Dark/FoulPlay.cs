using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dark
{
    internal class FoulPlay : PokeMove
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
            get { return _instance ?? (_instance = new FoulPlay()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FoulPlay()
            : base(
                492,
                "Foul Play",
                "Tricherie",
                "The user turns the target’s power against it. The higher the target’s Attack stat, the greater the damage it deals.",
                "Le lanceur utilise la force de l’ennemi. Plus l’Attaque de l’ennemi est élevée, plus le lanceur inflige de dégâts.",
                95,
                100,
                DamageClass.Physical,
                TypeDark.Instance
            ) { }
        #endregion
    }
}