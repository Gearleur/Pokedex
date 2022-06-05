using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Grass
{
    internal class EnergyBall : PokeMove
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
            get { return _instance ?? (_instance = new EnergyBall()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private EnergyBall()
            : base(
                412,
                "Energy Ball",
                "Éco-Sphère",
                "The user draws power from nature and fires it at the target. This may also lower the target’s Sp. Def stat.",
                "Utilise les pouvoirs de la nature pour attaquer l’ennemi. Peut aussi baisser sa Défense Spéciale.",
                90,
                100,
                DamageClass.Special,
                TypeGrass.Instance
            ) { }
        #endregion
    }
}