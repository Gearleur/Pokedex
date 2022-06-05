using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Grass
{
    internal class FrenzyPlant : PokeMove
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
            get { return _instance ?? (_instance = new FrenzyPlant()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FrenzyPlant()
            : base(
                338,
                "Frenzy Plant",
                "Végé-Attaque",
                "The user slams the target with the roots of an enormous tree. The user can’t move on the next turn.",
                "Un violent coup de racines s’abat sur l’ennemi. Immobilise le lanceur au tour suivant.",
                150,
                90,
                DamageClass.Special,
                TypeGrass.Instance
            ) { }
        #endregion
    }
}