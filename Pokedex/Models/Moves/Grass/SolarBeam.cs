using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Grass
{
    internal class SolarBeam : PokeMove
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
            get { return _instance ?? (_instance = new SolarBeam()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SolarBeam()
            : base(
                76,
                "Solar Beam",
                "Lance-Soleil",
                "In this two-turn attack, the user gathers light, then blasts a bundled beam on the next turn.",
                "Absorbe la lumière au premier tour et envoie un rayon puissant au tour suivant.",
                120,
                100,
                DamageClass.Special,
                TypeGrass.Instance
            ) { }
        #endregion
    }
}