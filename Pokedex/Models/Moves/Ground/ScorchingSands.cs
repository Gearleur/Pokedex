using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ground
{
    internal class ScorchingSands : PokeMove
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
            get { return _instance ?? (_instance = new ScorchingSands()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private ScorchingSands()
            : base(
                815,
                "Scorching Sands",
                "Sable Ardent",
                "The user throws scorching sand at the target to attack. This may also leave the target with a burn.",
                "Le lanceur projette du sable chauffé à blanc sur l’ennemi. Peut aussi brûler la cible.",
                70,
                100,
                DamageClass.Special,
                TypeGround.Instance
            ) { }
        #endregion
    }
}