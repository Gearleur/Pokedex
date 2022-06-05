using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class FirePledge : PokeMove
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
            get { return _instance ?? (_instance = new FirePledge()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FirePledge()
            : base(
                519,
                "Fire Pledge",
                "Aire de Feu",
                "A column of fire hits the target. When used with its grass equivalent, its power increases and a vast sea of fire appears.",
                "Une masse de feu s’abat sur l’ennemi. En l’utilisant avec Aire d’Herbe, l’effet augmente et une mer de feu apparaît.",
                80,
                100,
                DamageClass.Special,
                TypeFire.Instance
            ) { }
        #endregion
    }
}