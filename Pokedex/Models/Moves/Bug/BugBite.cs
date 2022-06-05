using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Bug
{
    internal class BugBite : PokeMove
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
            get { return _instance ?? (_instance = new BugBite()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private BugBite()
            : base(
                450,
                "Bug Bite",
                "Piqûre",
                "The user bites the target. If the target is holding a Berry, the user eats it and gains its effect.",
                "Le lanceur pique l’ennemi. Si ce dernier tient une Baie, le lanceur la dévore et obtient son effet.",
                60,
                100,
                DamageClass.Physical,
                TypeBug.Instance
            ) { }
        #endregion
    }
}