using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dragon
{
    internal class DragonRush : PokeMove
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
            get { return _instance ?? (_instance = new DragonRush()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DragonRush()
            : base(
                407,
                "Dragon Rush",
                "Draco-Charge",
                "The user tackles the target while exhibiting overwhelming menace. This may also make the target flinch.",
                "Le lanceur frappe l’ennemi en prenant un air menaçant. Peut aussi l’apeurer.",
                100,
                75,
                DamageClass.Physical,
                TypeDragon.Instance
            ) { }
        #endregion
    }
}