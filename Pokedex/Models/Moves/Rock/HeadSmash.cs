using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Rock
{
    internal class HeadSmash : PokeMove
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
            get { return _instance ?? (_instance = new HeadSmash()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private HeadSmash()
            : base(
                457,
                "Head Smash",
                "Fracass’Tête",
                "The user attacks the target with a hazardous, full-power headbutt. This also damages the user terribly.",
                "Le lanceur assène un coup de tête désespéré. Blesse aussi gravement le lanceur.",
                150,
                80,
                DamageClass.Physical,
                TypeRock.Instance
            ) { }
        #endregion
    }
}