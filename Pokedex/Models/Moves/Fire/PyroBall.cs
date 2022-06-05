using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class PyroBall : PokeMove
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
            get { return _instance ?? (_instance = new PyroBall()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private PyroBall()
            : base(
                780,
                "Pyro Ball",
                "Ballon Brûlant",
                "The user attacks by igniting a small stone and launching it as a fiery ball at the target. This may also leave the target with a burn.",
                "Le lanceur attaque avec un ballon fait à partir d’un caillou enflammé. Peut aussi brûler la cible.",
                120,
                90,
                DamageClass.Physical,
                TypeFire.Instance
            ) { }
        #endregion
    }
}