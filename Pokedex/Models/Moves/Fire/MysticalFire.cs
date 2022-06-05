using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class MysticalFire : PokeMove
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
            get { return _instance ?? (_instance = new MysticalFire()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private MysticalFire()
            : base(
                595,
                "Mystical Fire",
                "Feu Ensorcelé",
                "The user attacks by breathing a special, hot fire. This also lowers the target’s Sp. Atk stat.",
                "Attaque avec des flammes brûlantes soufflées de la bouche du lanceur. Diminue l’Attaque Spéciale de l’ennemi.",
                75,
                100,
                DamageClass.Special,
                TypeFire.Instance
            ) { }
        #endregion
    }
}