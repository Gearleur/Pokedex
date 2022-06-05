using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fighting
{
    internal class HighJumpKick : PokeMove
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
            get { return _instance ?? (_instance = new HighJumpKick()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private HighJumpKick()
            : base(
                136,
                "High Jump Kick",
                "Pied Voltige",
                "The target is attacked with a knee kick from a jump. If it misses, the user is hurt instead.",
                "Le lanceur s’élance pour effectuer un coup de genou sauté. S’il échoue, le lanceur se blesse.",
                130,
                90,
                DamageClass.Physical,
                TypeFighting.Instance
            ) { }
        #endregion
    }
}