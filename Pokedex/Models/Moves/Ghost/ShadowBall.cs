using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ghost
{
    internal class ShadowBall : PokeMove
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
            get { return _instance ?? (_instance = new ShadowBall()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private ShadowBall()
            : base(
                247,
                "Shadow Ball",
                "Ball’Ombre",
                "The user hurls a shadowy blob at the target. This may also lower the target’s Sp. Def stat.",
                "Projette une grande ombre sur l’ennemi. Peut aussi faire baisser sa Défense Spéciale.",
                80,
                100,
                DamageClass.Special,
                TypeGhost.Instance
            ) { }
        #endregion
    }
}