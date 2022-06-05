using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ground
{
    internal class MudShot : PokeMove
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
            get { return _instance ?? (_instance = new MudShot()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private MudShot()
            : base(
                341,
                "Mud Shot",
                "Tir de Boue",
                "The user attacks by hurling a blob of mud at the target. This also lowers the target’s Speed stat.",
                "Le lanceur attaque en projetant de la boue sur l’ennemi. Réduit aussi la Vitesse de la cible.",
                55,
                95,
                DamageClass.Special,
                TypeGround.Instance
            ) { }
        #endregion
    }
}