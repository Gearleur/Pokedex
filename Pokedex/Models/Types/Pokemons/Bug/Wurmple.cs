// https://www.pokemon.com/us/pokedex/265

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Wurmple : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Wurmple()); }
        }
        #endregion
        
        #region Constructors
        private Wurmple()
            : base(
                265,
                "Wurmple",
                "Chenipotte",
                TypeBug.Instance,
                3,
                36,
                "Worm Pokémon",
                "Pokémon Ver",
                "Wurmple is targeted by Swellow as prey. This Pokémon will try to resist by pointing the spikes on its rear at the attacking predator. It will weaken the foe by leaking poison from the spikes.",
                "Chenipotte est la proie de Hélédelle. Ce Pokémon essaie de résister en dirigeant les pointes de son dos vers le prédateur. Il affaiblit son ennemi en lui injectant du poison.",
                45,
                45,
                35,
                20,
                30,
                20
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
            this._moveList.Add(PoisonSting.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(Electroweb.Instance);
        }
        #endregion
    }
}