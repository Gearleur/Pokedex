using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Electric
{
    internal class Thunder : PokeMove
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
            get { return _instance ?? (_instance = new Thunder()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Thunder()
            : base(
                87,
                "Thunder",
                "Fatal-Foudre",
                "A wicked thunderbolt is dropped on the target to inflict damage. This may also leave the target with paralysis.",
                "La foudre tombe sur l’ennemi pour lui infliger des dégâts. Peut aussi le paralyser.",
                110,
                70,
                DamageClass.Special,
                TypeElectric.Instance
            ) { }
        #endregion
    }
}