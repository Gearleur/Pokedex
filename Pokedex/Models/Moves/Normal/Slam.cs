using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class Slam : PokeMove
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
            get { return _instance ?? (_instance = new Slam()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Slam()
            : base(
                21,
                "Slam",
                "Souplesse",
                "The target is slammed with a long tail, vines, or the like to inflict damage.",
                "Fouette l’ennemi avec la queue ou une liane, par exemple, pour infliger des dégâts.",
                80,
                75,
                DamageClass.Physical,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}