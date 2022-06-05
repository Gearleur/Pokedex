using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ground
{
    internal class Bulldoze : PokeMove
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
            get { return _instance ?? (_instance = new Bulldoze()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Bulldoze()
            : base(
                523,
                "Bulldoze",
                "Piétisol",
                "The user strikes everything around it by stomping down on the ground. This lowers the Speed stats of those hit.",
                "Le lanceur piétine le sol et inflige des dégâts à tous les Pokémon autour de lui. Baisse aussi leur Vitesse.",
                60,
                100,
                DamageClass.Physical,
                TypeGround.Instance
            ) { }
        #endregion
    }
}