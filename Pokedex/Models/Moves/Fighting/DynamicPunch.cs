using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fighting
{
    internal class DynamicPunch : PokeMove
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
            get { return _instance ?? (_instance = new DynamicPunch()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DynamicPunch()
            : base(
                223,
                "Dynamic Punch",
                "Dynamo-Poing",
                "The user punches the target with full, concentrated power. This confuses the target if it hits.",
                "Le lanceur rassemble ses forces et envoie un coup de poing à l’ennemi. Rend ce dernier confus.",
                100,
                50,
                DamageClass.Physical,
                TypeFighting.Instance
            ) { }
        #endregion
    }
}