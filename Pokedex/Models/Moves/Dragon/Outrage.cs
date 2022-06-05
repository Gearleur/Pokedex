using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dragon
{
    internal class Outrage : PokeMove
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
            get { return _instance ?? (_instance = new Outrage()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Outrage()
            : base(
                200,
                "Outrage",
                "Colère",
                "The user rampages and attacks for two to three turns. The user then becomes confused.",
                "Le lanceur enrage et attaque pendant deux ou trois tours avant de devenir confus.",
                120,
                100,
                DamageClass.Physical,
                TypeDragon.Instance
            ) { }
        #endregion
    }
}