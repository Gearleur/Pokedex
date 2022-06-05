using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ground
{
    internal class MudSlap : PokeMove
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
            get { return _instance ?? (_instance = new MudSlap()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private MudSlap()
            : base(
                189,
                "Mud-Slap",
                "Coud’Boue",
                "The user hurls mud in the target’s face to inflict damage and lower its accuracy.",
                "Le lanceur envoie de la boue au visage de l’ennemi pour infliger des dégâts et baisser sa Précision.",
                20,
                100,
                DamageClass.Special,
                TypeGround.Instance
            ) { }
        #endregion
    }
}