using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class SizzlySlide : PokeMove
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
            get { return _instance ?? (_instance = new SizzlySlide()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SizzlySlide()
            : base(
                735,
                "Sizzly Slide",
                "Évo-Flambo",
                "This move can’t be used. It’s recommended that this move is forgotten. Once forgotten, this move can’t be remembered.",
                "Cette capacité ne peut pas être utilisée. Il est recommandé de l’oublier, même s’il sera impossible de se la remémorer une fois oubliée.",
                60,
                100,
                DamageClass.Physical,
                TypeFire.Instance
            ) { }
        #endregion
    }
}