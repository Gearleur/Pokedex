using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fighting
{
    internal class SacredSword : PokeMove
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
            get { return _instance ?? (_instance = new SacredSword()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SacredSword()
            : base(
                533,
                "Sacred Sword",
                "Lame Sainte",
                "The user attacks by slicing with a long horn. The target’s stat changes don’t affect this attack’s damage.",
                "Un coup de corne violent qui lacère l’ennemi et lui inflige des dégâts quels que soient ses changements de stats.",
                90,
                100,
                DamageClass.Physical,
                TypeFighting.Instance
            ) { }
        #endregion
    }
}