// https://www.pokemon.com/us/pokedex/875

using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ice
{
    internal class EiscueIce : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new EiscueIce()); }
        }
        #endregion
        
        #region Constructors
        private EiscueIce()
            : base(
                875,
                "Eiscue",
                "Bekaglaçon",
                TypeIce.Instance,
                14,
                890,
                "Penguin Pokémon",
                "Pokémon Pingouin",
                "This Pokémon keeps its heat-sensitive head cool with ice. It fishes for its food, dangling its single hair into the sea to lure in prey.",
                "Ne supportant pas la chaleur, il se rafraîchit toujours la tête avec de la glace. Il pêche de quoi se nourrir à l’aide de son cheveu.",
                75,
                80,
                110,
                65,
                90,
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
            this._moveList.Add(IcePunch.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(PowderSnow.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(Whirlpool.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(IcicleSpear.Instance);
            this._moveList.Add(Brine.Instance);
            this._moveList.Add(Avalanche.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(HeadSmash.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(IcicleCrash.Instance);
            this._moveList.Add(FreezeDry.Instance);
            this._moveList.Add(Liquidation.Instance);
        }
        #endregion
    }
}