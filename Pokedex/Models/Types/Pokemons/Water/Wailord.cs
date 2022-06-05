// https://www.pokemon.com/us/pokedex/321

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Wailord : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Wailord()); }
        }
        #endregion
        
        #region Constructors
        private Wailord()
            : base(
                321,
                "Wailord",
                "Wailord",
                TypeWater.Instance,
                145,
                3980,
                "Float Whale Pokémon",
                "Pokémon Cachabouée",
                "Its immense size is the reason for its popularity. Wailord watching is a favorite sightseeing activity in various parts of the world.",
                "Sa taille fait de lui un Pokémon fascinant. Les sites touristiques proposant d’observer les Wailord ont toujours beaucoup de succès.",
                170,
                90,
                45,
                90,
                45,
                60
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
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(SelfDestruct.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Whirlpool.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(WaterSpout.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(Brine.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(Avalanche.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(Liquidation.Instance);
            this._moveList.Add(BodyPress.Instance);
            this._moveList.Add(SteelRoller.Instance);
        }
        #endregion
    }
}