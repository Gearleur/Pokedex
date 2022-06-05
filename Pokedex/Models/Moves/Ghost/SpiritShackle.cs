using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ghost
{
    internal class SpiritShackle : PokeMove
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
            get { return _instance ?? (_instance = new SpiritShackle()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SpiritShackle()
            : base(
                662,
                "Spirit Shackle",
                "Tisse Ombre",
                "The user attacks while simultaneously stitching the target’s shadow to the ground to prevent the target from escaping.",
                "Une attaque qui coud l’ennemi à son ombre, ce qui l’empêche de s’enfuir.",
                80,
                100,
                DamageClass.Physical,
                TypeGhost.Instance
            ) { }
        #endregion
    }
}