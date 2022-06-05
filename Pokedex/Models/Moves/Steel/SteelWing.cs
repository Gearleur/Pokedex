using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Steel
{
    internal class SteelWing : PokeMove
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
            get { return _instance ?? (_instance = new SteelWing()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SteelWing()
            : base(
                211,
                "Steel Wing",
                "Ailes d’Acier",
                "The target is hit with wings of steel. This may also raise the user’s Defense stat.",
                "Le lanceur frappe l’ennemi avec des ailes d’acier. Peut aussi augmenter la Défense du lanceur.",
                70,
                90,
                DamageClass.Physical,
                TypeSteel.Instance
            ) { }
        #endregion
    }
}