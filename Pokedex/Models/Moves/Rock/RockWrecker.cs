using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Rock
{
    internal class RockWrecker : PokeMove
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
            get { return _instance ?? (_instance = new RockWrecker()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private RockWrecker()
            : base(
                439,
                "Rock Wrecker",
                "Roc-Boulet",
                "The user launches a huge boulder at the target to attack. The user can’t move on the next turn.",
                "Le lanceur attaque en projetant un gros rocher sur l’ennemi. Il doit se reposer au tour suivant.",
                150,
                90,
                DamageClass.Physical,
                TypeRock.Instance
            ) { }
        #endregion
    }
}