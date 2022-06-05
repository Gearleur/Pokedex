// https://www.pokemon.com/us/pokedex/13

using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Weedle : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Weedle()); }
        }
        #endregion
        
        #region Constructors
        private Weedle()
            : base(
                13,
                "Weedle",
                "Aspicot",
                TypeBug.Instance,
                TypePoison.Instance,
                3,
                32,
                "Hairy Bug Pokémon",
                "Pokémon Insectopic",
                "Beware of the sharp stinger on its head. It hides in grass and bushes where it eats leaves.",
                "L’aiguillon sur son front est très pointu. Il se cache dans les bois et les hautes herbes, où il se gave de feuilles.",
                40,
                35,
                30,
                20,
                20,
                50
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
            this._moveList.Add(PoisonSting.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(Electroweb.Instance);
        }
        #endregion
    }
}