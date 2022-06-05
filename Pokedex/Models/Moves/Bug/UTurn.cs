using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Bug
{
    internal class UTurn : PokeMove
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
            get { return _instance ?? (_instance = new UTurn()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private UTurn()
            : base(
                369,
                "U-turn",
                "Demi-Tour",
                "After making its attack, the user rushes back to switch places with a party Pokémon in waiting.",
                "Après son attaque, le lanceur revient à toute vitesse et change de place avec un Pokémon de l’équipe prêt au combat.",
                70,
                100,
                DamageClass.Physical,
                TypeBug.Instance
            ) { }
        #endregion
    }
}