using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fighting
{
    internal class BrickBreak : PokeMove
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
            get { return _instance ?? (_instance = new BrickBreak()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private BrickBreak()
            : base(
                280,
                "Brick Break",
                "Casse-Brique",
                "The user attacks with a swift chop. It can also break barriers, such as Light Screen and Reflect.",
                "Le lanceur attaque avec le tranchant de la main. Permet aussi de briser les barrières comme Mur Lumière et Protection.",
                75,
                100,
                DamageClass.Physical,
                TypeFighting.Instance
            ) { }
        #endregion
    }
}