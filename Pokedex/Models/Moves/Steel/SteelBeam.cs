using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Steel
{
    internal class SteelBeam : PokeMove
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
            get { return _instance ?? (_instance = new SteelBeam()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SteelBeam()
            : base(
                796,
                "Steel Beam",
                "Métalaser",
                "The user fires a beam of steel that it collected from its entire body. This also damages the user.",
                "Le lanceur concentre du métal issu de tout son corps en un rayon qu’il projette violemment sur sa cible. Il subit aussi des dégâts.",
                140,
                95,
                DamageClass.Special,
                TypeSteel.Instance
            ) { }
        #endregion
    }
}