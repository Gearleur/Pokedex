using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Psy
{
    internal class PsychicFangs : PokeMove
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
            get { return _instance ?? (_instance = new PsychicFangs()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private PsychicFangs()
            : base(
                706,
                "Psychic Fangs",
                "Psycho-Croc",
                "The user bites the target with its psychic capabilities. This can also destroy Light Screen and Reflect.",
                "Le lanceur mord la cible avec ses pouvoirs psychiques. Brise aussi les barrières comme Mur Lumière et Protection.",
                85,
                100,
                DamageClass.Physical,
                TypePsy.Instance
            ) { }
        #endregion
    }
}