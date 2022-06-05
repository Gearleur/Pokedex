using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Steel
{
    internal class IronHead : PokeMove
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
            get { return _instance ?? (_instance = new IronHead()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private IronHead()
            : base(
                442,
                "Iron Head",
                "Tête de Fer",
                "The user slams the target with its steel-hard head. This may also make the target flinch.",
                "Le lanceur heurte l’ennemi avec sa tête dure comme de l’acier. Peut aussi l’apeurer.",
                80,
                100,
                DamageClass.Physical,
                TypeSteel.Instance
            ) { }
        #endregion
    }
}