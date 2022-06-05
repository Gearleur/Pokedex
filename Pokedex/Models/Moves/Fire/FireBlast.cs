using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class FireBlast : PokeMove
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
            get { return _instance ?? (_instance = new FireBlast()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FireBlast()
            : base(
                126,
                "Fire Blast",
                "Déflagration",
                "The target is attacked with an intense blast of all-consuming fire. This may also leave the target with a burn.",
                "Un déluge de flammes ardentes submerge l’ennemi. Peut aussi le brûler.",
                110,
                85,
                DamageClass.Special,
                TypeFire.Instance
            ) { }
        #endregion
    }
}