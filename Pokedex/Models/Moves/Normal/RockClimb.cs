using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class RockClimb : PokeMove
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
            get { return _instance ?? (_instance = new RockClimb()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private RockClimb()
            : base(
                431,
                "Rock Climb",
                "Escalade",
                "This move can’t be used. It’s recommended that this move is forgotten. Once forgotten, this move can’t be remembered.",
                "Cette capacité ne peut pas être utilisée. Il est recommandé de l’oublier, même s’il sera impossible de se la remémorer une fois oubliée.",
                90,
                85,
                DamageClass.Physical,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}