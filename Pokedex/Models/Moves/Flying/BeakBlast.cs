using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Flying
{
    internal class BeakBlast : PokeMove
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
            get { return _instance ?? (_instance = new BeakBlast()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private BeakBlast()
            : base(
                690,
                "Beak Blast",
                "Bec-Canon",
                "The user first heats up its beak, and then it attacks the target. Making direct contact with the Pokémon while it’s heating up its beak results in a burn.",
                "Le lanceur fait chauffer son bec avant d’attaquer. S’il subit une attaque directe pendant la montée en température, l’attaquant sera brûlé.",
                100,
                100,
                DamageClass.Physical,
                TypeFlying.Instance
            ) { }
        #endregion
    }
}