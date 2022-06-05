using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ice
{
    internal class IceBeam : PokeMove
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
            get { return _instance ?? (_instance = new IceBeam()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private IceBeam()
            : base(
                58,
                "Ice Beam",
                "Laser Glace",
                "The target is struck with an icy-cold beam of energy. This may also leave the target frozen.",
                "Un rayon de glace frappe l’ennemi. Peut aussi le geler.",
                90,
                100,
                DamageClass.Special,
                TypeIce.Instance
            ) { }
        #endregion
    }
}