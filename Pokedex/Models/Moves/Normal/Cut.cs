using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class Cut : PokeMove
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
            get { return _instance ?? (_instance = new Cut()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Cut()
            : base(
                15,
                "Cut",
                "Coupe",
                "The target is cut with a scythe or claw.",
                "Coupe l’ennemi avec des lames ou des griffes.",
                50,
                95,
                DamageClass.Physical,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}