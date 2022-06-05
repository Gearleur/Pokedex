using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class BlueFlare : PokeMove
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
            get { return _instance ?? (_instance = new BlueFlare()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private BlueFlare()
            : base(
                551,
                "Blue Flare",
                "Flamme Bleue",
                "The user attacks by engulfing the target in an intense, yet beautiful, blue flame. This may also leave the target with a burn.",
                "De magnifiques et redoutables flammes bleues fondent sur l’ennemi. Peut aussi le brûler.",
                130,
                85,
                DamageClass.Special,
                TypeFire.Instance
            ) { }
        #endregion
    }
}