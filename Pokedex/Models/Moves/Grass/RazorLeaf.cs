using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Grass
{
    internal class RazorLeaf : PokeMove
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
            get { return _instance ?? (_instance = new RazorLeaf()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private RazorLeaf()
            : base(
                75,
                "Razor Leaf",
                "Tranch’Herbe",
                "Sharp-edged leaves are launched to slash at opposing Pokémon. Critical hits land more easily.",
                "Des feuilles aiguisées comme des rasoirs entaillent l’ennemi. Taux de critiques élevé.",
                55,
                95,
                DamageClass.Physical,
                TypeGrass.Instance
            ) { }
        #endregion
    }
}