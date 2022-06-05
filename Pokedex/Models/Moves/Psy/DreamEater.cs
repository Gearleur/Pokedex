using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Psy
{
    internal class DreamEater : PokeMove
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
            get { return _instance ?? (_instance = new DreamEater()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DreamEater()
            : base(
                138,
                "Dream Eater",
                "Dévorêve",
                "The user eats the dreams of a sleeping target. The user’s HP is restored by half the damage taken by the target.",
                "Le lanceur mange le rêve de l’ennemi endormi et récupère en PV la moitié des dégâts infligés.",
                100,
                100,
                DamageClass.Special,
                TypePsy.Instance
            ) { }
        #endregion
    }
}