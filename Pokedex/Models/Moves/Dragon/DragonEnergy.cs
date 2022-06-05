using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dragon
{
    internal class DragonEnergy : PokeMove
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
            get { return _instance ?? (_instance = new DragonEnergy()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DragonEnergy()
            : base(
                820,
                "Dragon Energy",
                "Draco-Énergie",
                "Converting its life-force into power, the user attacks opposing Pokémon. The lower the user’s HP, the lower the move’s power.",
                "Le lanceur utilise son énergie vitale pour attaquer l’ennemi. Moins il a de PV, moins l’attaque est puissante.",
                150,
                100,
                DamageClass.Special,
                TypeDragon.Instance
            ) { }
        #endregion
    }
}