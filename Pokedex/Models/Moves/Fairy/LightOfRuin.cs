using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fairy
{
    internal class LightOfRuin : PokeMove
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
            get { return _instance ?? (_instance = new LightOfRuin()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private LightOfRuin()
            : base(
                617,
                "Light of Ruin",
                "Lumière du Néant",
                "Drawing power from the Eternal Flower, the user fires a powerful beam of light. This also damages the user quite a lot.",
                "Utilise la puissance de la fleur Éternelle pour lancer un formidable rayon d’énergie. Blesse aussi gravement le lanceur.",
                140,
                90,
                DamageClass.Special,
                TypeFairy.Instance
            ) { }
        #endregion
    }
}