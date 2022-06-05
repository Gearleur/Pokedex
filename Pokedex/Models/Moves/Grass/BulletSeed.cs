using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Grass
{
    internal class BulletSeed : PokeMove
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
            get { return _instance ?? (_instance = new BulletSeed()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private BulletSeed()
            : base(
                331,
                "Bullet Seed",
                "Balle Graine",
                "The user forcefully shoots seeds at the target two to five times in a row.",
                "Le lanceur mitraille l’ennemi avec une rafale de graines. De deux à cinq rafales sont lancées à la suite.",
                25,
                100,
                DamageClass.Physical,
                TypeGrass.Instance
            ) { }
        #endregion
    }
}