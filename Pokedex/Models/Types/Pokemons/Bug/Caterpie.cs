// https://www.pokemon.com/us/pokedex/10

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Caterpie : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Caterpie()); }
        }
        #endregion
        
        #region Constructors
        private Caterpie()
            : base(
                10,
                "Caterpie",
                "Chenipan",
                TypeBug.Instance,
                3,
                29,
                "Worm Pokémon",
                "Pokémon Ver",
                "Its short feet are tipped with suction pads that enable it to tirelessly climb slopes and walls.",
                "Ses petites pattes munies de ventouses lui permettent de monter les pentes et de grimper aux murs sans se fatiguer.",
                45,
                30,
                35,
                20,
                20,
                45
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
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(Electroweb.Instance);
        }
        #endregion
    }
}