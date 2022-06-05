using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fighting
{
    internal class DrainPunch : PokeMove
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
            get { return _instance ?? (_instance = new DrainPunch()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DrainPunch()
            : base(
                409,
                "Drain Punch",
                "Vampi-Poing",
                "An energy-draining punch. The user’s HP is restored by half the damage taken by the target.",
                "Un coup de poing qui draine l’énergie. Convertit la moitié des dégâts infligés en PV pour le lanceur.",
                75,
                100,
                DamageClass.Physical,
                TypeFighting.Instance
            ) { }
        #endregion
    }
}