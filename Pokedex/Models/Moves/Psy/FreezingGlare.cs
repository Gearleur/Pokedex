using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Psy
{
    internal class FreezingGlare : PokeMove
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
            get { return _instance ?? (_instance = new FreezingGlare()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FreezingGlare()
            : base(
                821,
                "Freezing Glare",
                "Regard Glaçant",
                "The user shoots its psychic power from its eyes to attack. This may also leave the target frozen.",
                "Les yeux du lanceur tirent des rayons psychiques. Peut aussi geler l’ennemi.",
                90,
                100,
                DamageClass.Special,
                TypePsy.Instance
            ) { }
        #endregion
    }
}