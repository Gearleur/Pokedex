using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class FieryDance : PokeMove
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
            get { return _instance ?? (_instance = new FieryDance()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FieryDance()
            : base(
                552,
                "Fiery Dance",
                "Danse du Feu",
                "Cloaked in flames, the user attacks the target by dancing and flapping its wings. This may also raise the user’s Sp. Atk stat.",
                "Le lanceur enveloppe l’ennemi de flammes. Peut aussi augmenter l’Attaque Spéciale du lanceur.",
                80,
                100,
                DamageClass.Special,
                TypeFire.Instance
            ) { }
        #endregion
    }
}