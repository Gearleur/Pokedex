using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Grass
{
    internal class LeafTornado : PokeMove
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
            get { return _instance ?? (_instance = new LeafTornado()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private LeafTornado()
            : base(
                536,
                "Leaf Tornado",
                "Phytomixeur",
                "The user attacks its target by encircling it in sharp leaves. This attack may also lower the target’s accuracy.",
                "L’ennemi est pris dans un tourbillon de feuilles acérées. Peut aussi baisser sa Précision.",
                65,
                90,
                DamageClass.Special,
                TypeGrass.Instance
            ) { }
        #endregion
    }
}