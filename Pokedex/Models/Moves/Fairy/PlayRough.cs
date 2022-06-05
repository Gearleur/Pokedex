using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fairy
{
    internal class PlayRough : PokeMove
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
            get { return _instance ?? (_instance = new PlayRough()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private PlayRough()
            : base(
                583,
                "Play Rough",
                "Câlinerie",
                "The user plays rough with the target and attacks it. This may also lower the target’s Attack stat.",
                "Attaque l’ennemi avec un câlin. Peut diminuer son Attaque.",
                90,
                90,
                DamageClass.Physical,
                TypeFairy.Instance
            ) { }
        #endregion
    }
}