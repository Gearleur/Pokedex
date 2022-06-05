using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ghost
{
    internal class Astonish : PokeMove
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
            get { return _instance ?? (_instance = new Astonish()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Astonish()
            : base(
                310,
                "Astonish",
                "Étonnement",
                "The user attacks the target while shouting in a startling fashion. This may also make the target flinch.",
                "Le lanceur attaque l’ennemi en poussant un cri terrifiant. Peut aussi l’apeurer.",
                30,
                100,
                DamageClass.Physical,
                TypeGhost.Instance
            ) { }
        #endregion
    }
}