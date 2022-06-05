using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class MindBlown : PokeMove
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
            get { return _instance ?? (_instance = new MindBlown()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private MindBlown()
            : base(
                720,
                "Mind Blown",
                "Caboche-Kaboum",
                "The user attacks everything around it by causing its own head to explode. This also damages the user.",
                "Le lanceur fait exploser sa tête pour attaquer toutes les cibles autour de lui. Il subit aussi des dégâts.",
                150,
                100,
                DamageClass.Special,
                TypeFire.Instance
            ) { }
        #endregion
    }
}