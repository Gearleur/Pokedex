using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Rock
{
    internal class Rollout : PokeMove
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
            get { return _instance ?? (_instance = new Rollout()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Rollout()
            : base(
                205,
                "Rollout",
                "Roulade",
                "The user continually rolls into the target over five turns. It becomes more powerful each time it hits.",
                "Un rocher roule sur l’ennemi pendant cinq tours. L’attaque gagne en puissance à chaque coup.",
                30,
                90,
                DamageClass.Physical,
                TypeRock.Instance
            ) { }
        #endregion
    }
}