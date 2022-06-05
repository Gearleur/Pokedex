using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Grass
{
    internal class LeafStorm : PokeMove
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
            get { return _instance ?? (_instance = new LeafStorm()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private LeafStorm()
            : base(
                437,
                "Leaf Storm",
                "Tempête Verte",
                "The user whips up a storm of leaves around the target. The attack’s recoil harshly lowers the user’s Sp. Atk stat.",
                "Invoque une tempête de feuilles acérées. Le contrecoup réduit beaucoup l’Attaque Spéciale du lanceur.",
                130,
                90,
                DamageClass.Special,
                TypeGrass.Instance
            ) { }
        #endregion
    }
}