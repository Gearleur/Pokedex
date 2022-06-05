using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Electric
{
    internal class Electroweb : PokeMove
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
            get { return _instance ?? (_instance = new Electroweb()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Electroweb()
            : base(
                527,
                "Electroweb",
                "Toile Élek",
                "The user attacks and captures opposing Pokémon using an electric net. This lowers their Speed stats.",
                "Attrape l’ennemi dans un filet électrique. Baisse aussi la Vitesse de l’ennemi.",
                55,
                95,
                DamageClass.Special,
                TypeElectric.Instance
            ) { }
        #endregion
    }
}