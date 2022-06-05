using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dragon
{
    internal class Twister : PokeMove
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
            get { return _instance ?? (_instance = new Twister()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Twister()
            : base(
                239,
                "Twister",
                "Ouragan",
                "The user whips up a vicious tornado to tear at opposing Pokémon. This may also make them flinch.",
                "Déclenche un terrible ouragan sur l’ennemi. Peut aussi l’apeurer.",
                40,
                100,
                DamageClass.Special,
                TypeDragon.Instance
            ) { }
        #endregion
    }
}