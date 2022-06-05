using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Psy
{
    internal class MistBall : PokeMove
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
            get { return _instance ?? (_instance = new MistBall()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private MistBall()
            : base(
                296,
                "Mist Ball",
                "Ball’Brume",
                "A mist-like flurry of down envelops and damages the target. This may also lower the target’s Sp. Atk stat.",
                "Une bulle de brume inflige des dégâts à l’ennemi. Peut aussi réduire son Attaque Spéciale.",
                70,
                100,
                DamageClass.Special,
                TypePsy.Instance
            ) { }
        #endregion
    }
}