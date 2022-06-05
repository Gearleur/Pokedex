using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ground
{
    internal class ThousandWaves : PokeMove
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
            get { return _instance ?? (_instance = new ThousandWaves()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private ThousandWaves()
            : base(
                615,
                "Thousand Waves",
                "Myria-Vagues",
                "The user attacks with a wave that crawls along the ground. Those it hits can’t flee from battle.",
                "Attaque avec des vagues glissant au sol. L’ennemi pris dedans ne peut pas s’échapper.",
                90,
                100,
                DamageClass.Physical,
                TypeGround.Instance
            ) { }
        #endregion
    }
}