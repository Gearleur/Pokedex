using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class BodySlam : PokeMove
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
            get { return _instance ?? (_instance = new BodySlam()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private BodySlam()
            : base(
                34,
                "Body Slam",
                "Plaquage",
                "The user drops onto the target with its full body weight. This may also leave the target with paralysis.",
                "Le lanceur se laisse tomber sur l’ennemi de tout son poids. Peut aussi le paralyser.",
                85,
                100,
                DamageClass.Physical,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}