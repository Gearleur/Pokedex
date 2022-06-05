using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Bug
{
    internal class StruggleBug : PokeMove
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
            get { return _instance ?? (_instance = new StruggleBug()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private StruggleBug()
            : base(
                522,
                "Struggle Bug",
                "Survinsecte",
                "While resisting, the user attacks opposing Pokémon. This lowers the Sp. Atk stats of those hit.",
                "Le lanceur se débat de toutes ses forces, et baisse l’Attaque Spéciale de l’ennemi.",
                50,
                100,
                DamageClass.Special,
                TypeBug.Instance
            ) { }
        #endregion
    }
}