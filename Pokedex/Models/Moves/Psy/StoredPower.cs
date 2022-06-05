using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Psy
{
    internal class StoredPower : PokeMove
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
            get { return _instance ?? (_instance = new StoredPower()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private StoredPower()
            : base(
                500,
                "Stored Power",
                "Force Ajoutée",
                "The user attacks the target with stored power. The more the user’s stats are raised, the greater the move’s power.",
                "Le lanceur attaque l’ennemi avec une force accumulée. Plus les stats du lanceur sont augmentées, plus le coup est efficace.",
                20,
                100,
                DamageClass.Special,
                TypePsy.Instance
            ) { }
        #endregion
    }
}