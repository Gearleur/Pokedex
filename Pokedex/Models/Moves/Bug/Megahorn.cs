using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Bug
{
    internal class Megahorn : PokeMove
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
            get { return _instance ?? (_instance = new Megahorn()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Megahorn()
            : base(
                224,
                "Megahorn",
                "Mégacorne",
                "Using its tough and impressive horn, the user rams into the target with no letup.",
                "Le lanceur utilise ses gigantesques cornes pour charger l’ennemi.",
                120,
                85,
                DamageClass.Physical,
                TypeBug.Instance
            ) { }
        #endregion
    }
}