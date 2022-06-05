using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Grass
{
    internal class DrumBeating : PokeMove
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
            get { return _instance ?? (_instance = new DrumBeating()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DrumBeating()
            : base(
                778,
                "Drum Beating",
                "Tambour Battant",
                "The user plays its drum, controlling the drum’s roots to attack the target. This also lowers the target’s Speed stat.",
                "Le lanceur bat son tambour pour en diriger les racines sur la cible, l’attaquer, et baisser sa Vitesse.",
                80,
                100,
                DamageClass.Physical,
                TypeGrass.Instance
            ) { }
        #endregion
    }
}