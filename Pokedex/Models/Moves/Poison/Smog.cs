using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Poison
{
    internal class Smog : PokeMove
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
            get { return _instance ?? (_instance = new Smog()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Smog()
            : base(
                123,
                "Smog",
                "Purédpois",
                "The target is attacked with a discharge of filthy gases. This may also poison the target.",
                "Le lanceur attaque à l’aide d’une éruption de gaz répugnants. Peut aussi empoisonner l’ennemi.",
                30,
                70,
                DamageClass.Special,
                TypePoison.Instance
            ) { }
        #endregion
    }
}