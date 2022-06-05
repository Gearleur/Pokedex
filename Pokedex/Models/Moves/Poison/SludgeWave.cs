using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Poison
{
    internal class SludgeWave : PokeMove
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
            get { return _instance ?? (_instance = new SludgeWave()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SludgeWave()
            : base(
                482,
                "Sludge Wave",
                "Cradovague",
                "The user strikes everything around it by swamping the area with a giant sludge wave. This may also poison those hit.",
                "Une vague de détritus attaque tous les Pokémon autour du lanceur. Peut aussi empoisonner.",
                95,
                100,
                DamageClass.Special,
                TypePoison.Instance
            ) { }
        #endregion
    }
}