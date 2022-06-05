// https://www.pokemon.com/us/pokedex/268

using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Cascoon : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Cascoon()); }
        }
        #endregion
        
        #region Constructors
        private Cascoon()
            : base(
                268,
                "Cascoon",
                "Blindalys",
                TypeBug.Instance,
                7,
                115,
                "Cocoon Pokémon",
                "Pokémon Cocon",
                "If it is attacked, Cascoon remains motionless however badly it may be hurt. It does so because if it were to move, its body would be weak upon evolution. This Pokémon will also not forget the pain it endured.",
                "Lorsqu’il est attaqué, Blindalys reste immobile, même s’il a très mal. En effet, s’il bougeait, son corps serait affaibli lors de son évolution. En revanche, ce Pokémon n’oubliera pas la douleur endurée.",
                50,
                35,
                55,
                25,
                25,
                15
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
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(Electroweb.Instance);
        }
        #endregion
    }
}