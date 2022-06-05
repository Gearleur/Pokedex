using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class Facade : PokeMove
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
            get { return _instance ?? (_instance = new Facade()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Facade()
            : base(
                263,
                "Facade",
                "Façade",
                "This attack move doubles its power if the user is poisoned, burned, or paralyzed.",
                "Une attaque dont la puissance double lorsque le lanceur est empoisonné, paralysé ou brûlé.",
                70,
                100,
                DamageClass.Physical,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}