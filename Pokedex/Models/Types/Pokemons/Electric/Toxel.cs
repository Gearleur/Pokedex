// https://www.pokemon.com/us/pokedex/848

using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Electric
{
    internal class Toxel : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Toxel()); }
        }
        #endregion
        
        #region Constructors
        private Toxel()
            : base(
                848,
                "Toxel",
                "Toxizap",
                TypeElectric.Instance,
                TypePoison.Instance,
                4,
                110,
                "Baby Pokémon",
                "Pokémon Poupon",
                "It manipulates the chemical makeup of its poison to produce electricity. The voltage is weak, but it can cause a tingling paralysis.",
                "Par un procédé chimique, il change son poison en électricité. L’intensité du courant est faible, mais peut engourdir un ennemi.",
                40,
                38,
                35,
                54,
                35,
                40
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
            this._moveList.Add(Acid.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Belch.Instance);
            this._moveList.Add(Nuzzle.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
        }
        #endregion
    }
}