// https://www.pokemon.com/us/pokedex/360

using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Psy
{
    internal class Wynaut : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Wynaut()); }
        }
        #endregion
        
        #region Constructors
        private Wynaut()
            : base(
                360,
                "Wynaut",
                "Okéoké",
                TypePsy.Instance,
                6,
                140,
                "Bright Pokémon",
                "Pokémon Ravi",
                "It tends to move in a pack with others. They cluster in a tight group to sleep in a cave.",
                "Ces Pokémon adorent se déplacer en groupe. Ils se blottissent les uns contre les autres dans des cavernes pour dormir.",
                95,
                23,
                48,
                23,
                48,
                23
            )
        { }
        #endregion

        #region Methods
        /// <summary>
        /// Implementation of the parent method
        /// </summary>
        /// <seealso cref="Pokemon.InitMoveList"/>
        public override void InitMoveList()
        {
            this._moveList = new List<PokeMove>();
        }
        #endregion
    }
}