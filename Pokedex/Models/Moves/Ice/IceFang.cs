using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ice
{
    internal class IceFang : PokeMove
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
            get { return _instance ?? (_instance = new IceFang()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private IceFang()
            : base(
                423,
                "Ice Fang",
                "Crocs Givre",
                "The user bites with cold-infused fangs. This may also make the target flinch or leave it frozen.",
                "Le lanceur utilise une morsure glaciale. Peut aussi geler ou apeurer l’ennemi.",
                65,
                95,
                DamageClass.Physical,
                TypeIce.Instance
            ) { }
        #endregion
    }
}