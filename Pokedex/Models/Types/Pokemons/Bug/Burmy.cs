// https://www.pokemon.com/us/pokedex/412

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Burmy : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Burmy()); }
        }
        #endregion
        
        #region Constructors
        private Burmy()
            : base(
                412,
                "Burmy",
                "Cheniti",
                TypeBug.Instance,
                2,
                34,
                "Bagworm Pokémon",
                "Pokémon Ver Caché",
                "If its cloak is broken in battle, it quickly remakes the cloak with materials nearby.",
                "S’il perd sa cape au combat, il en tisse rapidement une nouvelle avec ce qui lui tombe sous la main.",
                40,
                29,
                45,
                29,
                45,
                36
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
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(Electroweb.Instance);
        }
        #endregion
    }
}