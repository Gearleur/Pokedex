using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dark
{
    internal class DarkestLariat : PokeMove
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
            get { return _instance ?? (_instance = new DarkestLariat()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DarkestLariat()
            : base(
                663,
                "Darkest Lariat",
                "Dark Lariat",
                "The user swings both arms and hits the target. The target’s stat changes don’t affect this attack’s damage.",
                "Le Pokémon étend les bras et frappe l’adversaire en tournant violemment. Inflige des dégâts et ignore les changements de stats de la cible.",
                85,
                100,
                DamageClass.Physical,
                TypeDark.Instance
            ) { }
        #endregion
    }
}