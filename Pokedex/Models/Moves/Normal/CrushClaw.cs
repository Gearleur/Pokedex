using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class CrushClaw : PokeMove
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
            get { return _instance ?? (_instance = new CrushClaw()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private CrushClaw()
            : base(
                306,
                "Crush Claw",
                "Éclate Griffe",
                "The user slashes the target with hard and sharp claws. This may also lower the target’s Defense stat.",
                "Lacère l’ennemi avec des griffes solides et aiguisées. Peut aussi baisser sa Défense.",
                75,
                95,
                DamageClass.Physical,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}