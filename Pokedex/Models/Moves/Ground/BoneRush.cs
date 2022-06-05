using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ground
{
    internal class BoneRush : PokeMove
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
            get { return _instance ?? (_instance = new BoneRush()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private BoneRush()
            : base(
                198,
                "Bone Rush",
                "Charge Os",
                "The user strikes the target with a hard bone two to five times in a row.",
                "Le lanceur frappe l’ennemi avec un os de deux à cinq fois d’affilée.",
                25,
                90,
                DamageClass.Physical,
                TypeGround.Instance
            ) { }
        #endregion
    }
}