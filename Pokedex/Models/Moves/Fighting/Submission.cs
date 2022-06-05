using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fighting
{
    internal class Submission : PokeMove
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
            get { return _instance ?? (_instance = new Submission()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Submission()
            : base(
                66,
                "Submission",
                "Sacrifice",
                "The user grabs the target and recklessly dives for the ground. This also damages the user a little.",
                "Le lanceur agrippe l’ennemi et l’écrase au sol. Blesse aussi légèrement le lanceur.",
                80,
                80,
                DamageClass.Physical,
                TypeFighting.Instance
            ) { }
        #endregion
    }
}