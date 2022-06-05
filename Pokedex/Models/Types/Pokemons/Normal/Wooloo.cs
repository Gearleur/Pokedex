// https://www.pokemon.com/us/pokedex/831

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Wooloo : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Wooloo()); }
        }
        #endregion
        
        #region Constructors
        private Wooloo()
            : base(
                831,
                "Wooloo",
                "Moumouton",
                TypeNormal.Instance,
                6,
                60,
                "Sheep Pokémon",
                "Pokémon Mouton",
                "If its fleece grows too long, Wooloo won’t be able to move. Cloth made with the wool of this Pokémon is surprisingly strong.",
                "Si ses poils poussent trop, il ne peut plus bouger. Les étoffes tissées avec son pelage sont étonnamment solides.",
                42,
                40,
                55,
                40,
                45,
                48
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
            this._moveList.Add(Stomp.Instance);
            this._moveList.Add(DoubleKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(GrassyGlide.Instance);
        }
        #endregion
    }
}