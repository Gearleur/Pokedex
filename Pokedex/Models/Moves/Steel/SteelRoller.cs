using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Steel
{
    internal class SteelRoller : PokeMove
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
            get { return _instance ?? (_instance = new SteelRoller()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SteelRoller()
            : base(
                798,
                "Steel Roller",
                "Métalliroue",
                "The user attacks while destroying the terrain. This move fails when the ground hasn’t turned into a terrain.",
                "Une attaque qui inflige des dégâts et fait disparaître le champ actif, mais qui échoue s’il n’y en a pas à ce moment.",
                130,
                100,
                DamageClass.Physical,
                TypeSteel.Instance
            ) { }
        #endregion
    }
}