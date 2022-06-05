using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fairy
{
    internal class DazzlingGleam : PokeMove
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
            get { return _instance ?? (_instance = new DazzlingGleam()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DazzlingGleam()
            : base(
                605,
                "Dazzling Gleam",
                "Éclat Magique",
                "The user damages opposing Pokémon by emitting a powerful flash.",
                "Libère une puissante décharge lumineuse qui inflige des dégâts à l’ennemi.",
                80,
                100,
                DamageClass.Special,
                TypeFairy.Instance
            ) { }
        #endregion
    }
}