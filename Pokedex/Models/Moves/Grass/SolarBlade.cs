using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Grass
{
    internal class SolarBlade : PokeMove
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
            get { return _instance ?? (_instance = new SolarBlade()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SolarBlade()
            : base(
                669,
                "Solar Blade",
                "Lame Solaire",
                "In this two-turn attack, the user gathers light and fills a blade with the light’s energy, attacking the target on the next turn.",
                "Le lanceur absorbe la lumière au premier tour et attaque au second tour en libérant cette énergie sous forme de lames.",
                125,
                100,
                DamageClass.Physical,
                TypeGrass.Instance
            ) { }
        #endregion
    }
}