using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Steel
{
    internal class GearGrind : PokeMove
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
            get { return _instance ?? (_instance = new GearGrind()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private GearGrind()
            : base(
                544,
                "Gear Grind",
                "Lancécrou",
                "The user attacks by throwing steel gears at its target twice.",
                "Le lanceur jette deux écrous d’acier qui frappent l’ennemi deux fois d’affilée.",
                50,
                85,
                DamageClass.Physical,
                TypeSteel.Instance
            ) { }
        #endregion
    }
}