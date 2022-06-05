using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Grass
{
    internal class LeafBlade : PokeMove
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
            get { return _instance ?? (_instance = new LeafBlade()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private LeafBlade()
            : base(
                348,
                "Leaf Blade",
                "Lame Feuille",
                "The user handles a sharp leaf like a sword and attacks by cutting its target. Critical hits land more easily.",
                "Une feuille coupante comme une lame entaille l’ennemi. Taux de critiques élevé.",
                90,
                100,
                DamageClass.Physical,
                TypeGrass.Instance
            ) { }
        #endregion
    }
}