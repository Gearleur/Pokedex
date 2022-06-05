using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ice
{
    internal class Glaciate : PokeMove
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
            get { return _instance ?? (_instance = new Glaciate()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Glaciate()
            : base(
                549,
                "Glaciate",
                "Ère Glaciaire",
                "The user attacks by blowing freezing cold air at opposing Pokémon. This lowers their Speed stats.",
                "Un souffle de vent qui congèle tout sur son passage s’abat sur l’ennemi. Réduit aussi sa Vitesse.",
                65,
                95,
                DamageClass.Special,
                TypeIce.Instance
            ) { }
        #endregion
    }
}