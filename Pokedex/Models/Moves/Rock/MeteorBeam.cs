using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Rock
{
    internal class MeteorBeam : PokeMove
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
            get { return _instance ?? (_instance = new MeteorBeam()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private MeteorBeam()
            : base(
                800,
                "Meteor Beam",
                "Laser Météore",
                "In this two-turn attack, the user gathers space power and boosts its Sp. Atk stat, then attacks the target on the next turn.",
                "Le lanceur concentre l’énergie cosmique au premier tour, ce qui augmente son Attaque Spéciale, et frappe au second.",
                120,
                90,
                DamageClass.Special,
                TypeRock.Instance
            ) { }
        #endregion
    }
}