using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class Surf : PokeMove
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
            get { return _instance ?? (_instance = new Surf()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Surf()
            : base(
                57,
                "Surf",
                "Surf",
                "The user attacks everything around it by swamping its surroundings with a giant wave.",
                "Une énorme vague s’abat sur le champ de bataille et inflige des dégâts à tous les Pokémon autour du lanceur.",
                90,
                100,
                DamageClass.Special,
                TypeWater.Instance
            ) { }
        #endregion
    }
}