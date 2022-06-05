using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dragon
{
    internal class ClangingScales : PokeMove
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
            get { return _instance ?? (_instance = new ClangingScales()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private ClangingScales()
            : base(
                691,
                "Clanging Scales",
                "Vibrécaille",
                "The user rubs the scales on its entire body and makes a huge noise to attack opposing Pokémon. The user’s Defense stat goes down after the attack.",
                "Le lanceur déclenche un vacarme en frottant ses écailles les unes contre les autres pour attaquer. Baisse la Défense du lanceur.",
                110,
                100,
                DamageClass.Special,
                TypeDragon.Instance
            ) { }
        #endregion
    }
}