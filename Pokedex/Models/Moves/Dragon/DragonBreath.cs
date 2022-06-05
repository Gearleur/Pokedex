using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dragon
{
    internal class DragonBreath : PokeMove
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
            get { return _instance ?? (_instance = new DragonBreath()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DragonBreath()
            : base(
                225,
                "Dragon Breath",
                "Draco-Souffle",
                "The user exhales a mighty gust that inflicts damage. This may also leave the target with paralysis.",
                "Le lanceur souffle fort sur l’ennemi pour lui infliger des dégâts. Peut aussi le paralyser.",
                60,
                100,
                DamageClass.Special,
                TypeDragon.Instance
            ) { }
        #endregion
    }
}