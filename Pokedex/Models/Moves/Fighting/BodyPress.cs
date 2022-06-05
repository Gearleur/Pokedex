using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fighting
{
    internal class BodyPress : PokeMove
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
            get { return _instance ?? (_instance = new BodyPress()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private BodyPress()
            : base(
                776,
                "Body Press",
                "Big Splash",
                "The user attacks by slamming its body into the target. The higher the user’s Defense, the more damage it can inflict on the target.",
                "Le lanceur utilise son corps pour attaquer sa cible. Plus la Défense du lanceur est élevée, plus les dégâts infligés sont importants.",
                80,
                100,
                DamageClass.Physical,
                TypeFighting.Instance
            ) { }
        #endregion
    }
}