using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class Flamethrower : PokeMove
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
            get { return _instance ?? (_instance = new Flamethrower()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Flamethrower()
            : base(
                53,
                "Flamethrower",
                "Lance-Flammes",
                "The target is scorched with an intense blast of fire. This may also leave the target with a burn.",
                "L’ennemi reçoit un torrent de flammes. Peut aussi le brûler.",
                90,
                100,
                DamageClass.Special,
                TypeFire.Instance
            ) { }
        #endregion
    }
}