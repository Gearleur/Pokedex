using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Psy
{
    internal class LusterPurge : PokeMove
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
            get { return _instance ?? (_instance = new LusterPurge()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private LusterPurge()
            : base(
                295,
                "Luster Purge",
                "Lumi-Éclat",
                "The user lets loose a damaging burst of light. This may also lower the target’s Sp. Def stat.",
                "Le lanceur libère un éclair lumineux. Peut aussi baisser la Défense Spéciale de l’ennemi.",
                70,
                100,
                DamageClass.Special,
                TypePsy.Instance
            ) { }
        #endregion
    }
}