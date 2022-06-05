using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class Overheat : PokeMove
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
            get { return _instance ?? (_instance = new Overheat()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Overheat()
            : base(
                315,
                "Overheat",
                "Surchauffe",
                "The user attacks the target at full power. The attack’s recoil harshly lowers the user’s Sp. Atk stat.",
                "Attaque l’ennemi à pleine puissance. Le contrecoup baisse beaucoup l’Attaque Spéciale du lanceur.",
                130,
                90,
                DamageClass.Special,
                TypeFire.Instance
            ) { }
        #endregion
    }
}