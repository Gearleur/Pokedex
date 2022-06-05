using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class Ember : PokeMove
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
            get { return _instance ?? (_instance = new Ember()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Ember()
            : base(
                52,
                "Ember",
                "Flammèche",
                "The target is attacked with small flames. This may also leave the target with a burn.",
                "L’ennemi est attaqué par une faible flamme. Peut aussi le brûler.",
                40,
                100,
                DamageClass.Special,
                TypeFire.Instance
            ) { }
        #endregion
    }
}