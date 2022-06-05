using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class HyperFang : PokeMove
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
            get { return _instance ?? (_instance = new HyperFang()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private HyperFang()
            : base(
                158,
                "Hyper Fang",
                "Croc de Mort",
                "The user bites hard on the target with its sharp front fangs. This may also make the target flinch.",
                "Le lanceur mord l’ennemi à l’aide de ses incisives aiguisées. Peut aussi l’apeurer.",
                80,
                90,
                DamageClass.Physical,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}