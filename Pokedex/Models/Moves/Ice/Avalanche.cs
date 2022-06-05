using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ice
{
    internal class Avalanche : PokeMove
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
            get { return _instance ?? (_instance = new Avalanche()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Avalanche()
            : base(
                419,
                "Avalanche",
                "Avalanche",
                "The power of this attack move is doubled if the user has been hurt by the target in the same turn.",
                "Une attaque deux fois plus puissante si le lanceur a été blessé par l’ennemi durant le tour.",
                60,
                100,
                DamageClass.Physical,
                TypeIce.Instance
            ) { }
        #endregion
    }
}