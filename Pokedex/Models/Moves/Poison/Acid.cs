using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Poison
{
    internal class Acid : PokeMove
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
            get { return _instance ?? (_instance = new Acid()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Acid()
            : base(
                51,
                "Acid",
                "Acide",
                "Opposing Pokémon are attacked with a spray of harsh acid. This may also lower their Sp. Def stats.",
                "Le lanceur attaque l’ennemi avec un jet d’acide corrosif. Peut aussi baisser sa Défense Spéciale.",
                40,
                100,
                DamageClass.Special,
                TypePoison.Instance
            ) { }
        #endregion
    }
}