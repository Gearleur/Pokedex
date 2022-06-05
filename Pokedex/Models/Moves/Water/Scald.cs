using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class Scald : PokeMove
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
            get { return _instance ?? (_instance = new Scald()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Scald()
            : base(
                503,
                "Scald",
                "Ébullition",
                "The user shoots boiling hot water at its target. This may also leave the target with a burn.",
                "L’ennemi est attaqué par un jet d’eau bouillante. Peut aussi le brûler.",
                80,
                100,
                DamageClass.Special,
                TypeWater.Instance
            ) { }
        #endregion
    }
}