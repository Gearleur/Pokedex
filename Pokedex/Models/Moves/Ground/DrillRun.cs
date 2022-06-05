using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ground
{
    internal class DrillRun : PokeMove
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
            get { return _instance ?? (_instance = new DrillRun()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DrillRun()
            : base(
                529,
                "Drill Run",
                "Tunnelier",
                "The user crashes into its target while rotating its body like a drill. Critical hits land more easily.",
                "Le lanceur tourne sur lui-même comme une perceuse et se jette sur l’ennemi. Taux de critiques élevé.",
                80,
                95,
                DamageClass.Physical,
                TypeGround.Instance
            ) { }
        #endregion
    }
}