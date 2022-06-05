using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dragon
{
    internal class DragonHammer : PokeMove
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
            get { return _instance ?? (_instance = new DragonHammer()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DragonHammer()
            : base(
                692,
                "Dragon Hammer",
                "Draco-Marteau",
                "The user uses its body like a hammer to attack the target and inflict damage.",
                "Le lanceur utilise son corps comme un véritable marteau pour écraser la cible.",
                90,
                100,
                DamageClass.Physical,
                TypeDragon.Instance
            ) { }
        #endregion
    }
}