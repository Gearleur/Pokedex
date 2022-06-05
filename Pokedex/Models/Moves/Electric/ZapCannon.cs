using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Electric
{
    internal class ZapCannon : PokeMove
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
            get { return _instance ?? (_instance = new ZapCannon()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private ZapCannon()
            : base(
                192,
                "Zap Cannon",
                "Élecanon",
                "The user fires an electric blast like a cannon to inflict damage and cause paralysis.",
                "Un boulet de canon électrifié qui inflige des dégâts et paralyse l’ennemi.",
                120,
                50,
                DamageClass.Special,
                TypeElectric.Instance
            ) { }
        #endregion
    }
}