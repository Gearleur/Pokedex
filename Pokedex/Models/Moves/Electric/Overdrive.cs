using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Electric
{
    internal class Overdrive : PokeMove
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
            get { return _instance ?? (_instance = new Overdrive()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Overdrive()
            : base(
                786,
                "Overdrive",
                "Overdrive",
                "The user attacks opposing Pokémon by twanging a guitar or bass guitar, causing a huge echo and strong vibration.",
                "Le lanceur gratte ses cordes de guitare ou de basse pour créer de violentes vibrations sonores qui blessent la cible.",
                80,
                100,
                DamageClass.Special,
                TypeElectric.Instance
            ) { }
        #endregion
    }
}