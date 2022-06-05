using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dragon
{
    internal class Eternabeam : PokeMove
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
            get { return _instance ?? (_instance = new Eternabeam()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Eternabeam()
            : base(
                795,
                "Eternabeam",
                "Laser Infinimax",
                "This is Eternatus’s most powerful attack in its original form. The user can’t move on the next turn.",
                "L’attaque la plus puissante d’Éthernatos sous sa forme originelle. S’il l’utilise, il devra se reposer au tour suivant.",
                160,
                90,
                DamageClass.Special,
                TypeDragon.Instance
            ) { }
        #endregion
    }
}