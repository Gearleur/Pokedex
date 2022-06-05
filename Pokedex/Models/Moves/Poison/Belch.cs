using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Poison
{
    internal class Belch : PokeMove
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
            get { return _instance ?? (_instance = new Belch()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Belch()
            : base(
                562,
                "Belch",
                "Éructation",
                "The user lets out a damaging belch at the target. The user must eat a held Berry to use this move.",
                "Le lanceur se tourne vers l’ennemi et lui éructe dessus, infligeant des dégâts. Ne fonctionne que si le lanceur consomme la Baie qu’il tient.",
                120,
                90,
                DamageClass.Special,
                TypePoison.Instance
            ) { }
        #endregion
    }
}