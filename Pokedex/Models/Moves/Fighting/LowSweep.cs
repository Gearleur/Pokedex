using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fighting
{
    internal class LowSweep : PokeMove
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
            get { return _instance ?? (_instance = new LowSweep()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private LowSweep()
            : base(
                490,
                "Low Sweep",
                "Balayette",
                "The user makes a swift attack on the target’s legs, which lowers the target’s Speed stat.",
                "Un coup rapide qui affecte la mobilité de l’ennemi et diminue sa Vitesse.",
                65,
                100,
                DamageClass.Physical,
                TypeFighting.Instance
            ) { }
        #endregion
    }
}