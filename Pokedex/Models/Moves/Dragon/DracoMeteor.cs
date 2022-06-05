using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dragon
{
    internal class DracoMeteor : PokeMove
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
            get { return _instance ?? (_instance = new DracoMeteor()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DracoMeteor()
            : base(
                434,
                "Draco Meteor",
                "Draco-Météore",
                "Comets are summoned down from the sky onto the target. The attack’s recoil harshly lowers the user’s Sp. Atk stat.",
                "Le lanceur invoque des comètes. Le contrecoup réduit beaucoup son Attaque Spéciale.",
                130,
                90,
                DamageClass.Special,
                TypeDragon.Instance
            ) { }
        #endregion
    }
}