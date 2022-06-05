using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ground
{
    internal class StompingTantrum : PokeMove
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
            get { return _instance ?? (_instance = new StompingTantrum()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private StompingTantrum()
            : base(
                707,
                "Stomping Tantrum",
                "Trépignement",
                "Driven by frustration, the user attacks the target. If the user’s previous move has failed, the power of this move doubles.",
                "Le lanceur attaque en utilisant sa frustration. S’il a utilisé une capacité qui a échoué au tour précédent, la puissance de Trépignement est doublée.",
                75,
                100,
                DamageClass.Physical,
                TypeGround.Instance
            ) { }
        #endregion
    }
}