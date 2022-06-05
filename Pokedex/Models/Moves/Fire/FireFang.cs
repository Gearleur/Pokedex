using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class FireFang : PokeMove
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
            get { return _instance ?? (_instance = new FireFang()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FireFang()
            : base(
                424,
                "Fire Fang",
                "Crocs Feu",
                "The user bites with flame-cloaked fangs. This may also make the target flinch or leave it with a burn.",
                "Le lanceur utilise une morsure enflammée. Peut aussi brûler ou apeurer l’ennemi.",
                65,
                95,
                DamageClass.Physical,
                TypeFire.Instance
            ) { }
        #endregion
    }
}