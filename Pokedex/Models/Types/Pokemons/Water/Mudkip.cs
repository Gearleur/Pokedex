// https://www.pokemon.com/us/pokedex/258

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Mudkip : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Mudkip()); }
        }
        #endregion
        
        #region Constructors
        private Mudkip()
            : base(
                258,
                "Mudkip",
                "Gobou",
                TypeWater.Instance,
                4,
                76,
                "Mud Fish Pokémon",
                "Pokémon Poissonboue",
                "In water, Mudkip breathes using the gills on its cheeks. If it is faced with a tight situation in battle, this Pokémon will unleash its amazing power—it can crush rocks bigger than itself.",
                "Sous l’eau, Gobou peut respirer grâce aux branchies sur ses joues. S’il se retrouve en difficulté pendant un combat, ce Pokémon déchaîne ses pouvoirs incroyables. Il peut détruire des rochers plus gros que lui.",
                50,
                70,
                50,
                50,
                50,
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
            this._moveList.Add(Stomp.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(RockThrow.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Sludge.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Whirlpool.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(IceBall.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(Avalanche.Instance);
            this._moveList.Add(MudBomb.Instance);
            this._moveList.Add(SludgeWave.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(WaterPledge.Instance);
        }
        #endregion
    }
}