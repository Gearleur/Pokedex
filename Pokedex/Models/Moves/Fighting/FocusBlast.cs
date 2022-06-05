using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fighting
{
    internal class FocusBlast : PokeMove
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
            get { return _instance ?? (_instance = new FocusBlast()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FocusBlast()
            : base(
                411,
                "Focus Blast",
                "Exploforce",
                "The user heightens its mental focus and unleashes its power. This may also lower the target’s Sp. Def stat.",
                "Le lanceur rassemble ses forces et laisse éclater son pouvoir. Peut aussi baisser la Défense Spéciale de l’ennemi.",
                120,
                70,
                DamageClass.Special,
                TypeFighting.Instance
            ) { }
        #endregion
    }
}