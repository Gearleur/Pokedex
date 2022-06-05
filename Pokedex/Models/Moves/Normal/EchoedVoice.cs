using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class EchoedVoice : PokeMove
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
            get { return _instance ?? (_instance = new EchoedVoice()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private EchoedVoice()
            : base(
                497,
                "Echoed Voice",
                "Écho",
                "The user attacks the target with an echoing voice. If this move is used every turn, its power is increased.",
                "Un cri retentissant blesse l’ennemi. Si le lanceur ou d’autres Pokémon l’utilisent à chaque tour, l’effet augmente.",
                40,
                100,
                DamageClass.Special,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}