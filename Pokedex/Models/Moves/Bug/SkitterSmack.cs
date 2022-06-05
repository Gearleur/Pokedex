using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Bug
{
    internal class SkitterSmack : PokeMove
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
            get { return _instance ?? (_instance = new SkitterSmack()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SkitterSmack()
            : base(
                806,
                "Skitter Smack",
                "Ravage Rampant",
                "The user skitters behind the target to attack. This also lowers the target’s Sp. Atk stat.",
                "Le lanceur rampe derrière l’ennemi pour l’attaquer. Baisse l’Attaque Spéciale de la cible.",
                70,
                90,
                DamageClass.Physical,
                TypeBug.Instance
            ) { }
        #endregion
    }
}