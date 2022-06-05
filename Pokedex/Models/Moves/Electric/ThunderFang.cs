using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Electric
{
    internal class ThunderFang : PokeMove
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
            get { return _instance ?? (_instance = new ThunderFang()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private ThunderFang()
            : base(
                422,
                "Thunder Fang",
                "Crocs Éclair",
                "The user bites with electrified fangs. This may also make the target flinch or leave it with paralysis.",
                "Le lanceur utilise une morsure électrifiée. Peut aussi paralyser ou apeurer l’ennemi.",
                65,
                95,
                DamageClass.Physical,
                TypeElectric.Instance
            ) { }
        #endregion
    }
}