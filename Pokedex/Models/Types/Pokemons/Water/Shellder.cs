// https://www.pokemon.com/us/pokedex/90

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Shellder : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Shellder()); }
        }
        #endregion
        
        #region Constructors
        private Shellder()
            : base(
                90,
                "Shellder",
                "Kokiyas",
                TypeWater.Instance,
                3,
                40,
                "Bivalve Pokémon",
                "Pokémon Bivalve",
                "Its hard shell repels any kind of attack. It is vulnerable only when its shell is open.",
                "Sa coquille est si résistante qu’elle repousse toutes les attaques. En revanche, il est vulnérable quand celle-ci s’ouvre.",
                30,
                65,
                100,
                45,
                25,
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
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Twineedle.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(BubbleBeam.Instance);
            this._moveList.Add(AuroraBeam.Instance);
            this._moveList.Add(Rage.Instance);
            this._moveList.Add(SelfDestruct.Instance);
            this._moveList.Add(Clamp.Instance);
            this._moveList.Add(Explosion.Instance);
            this._moveList.Add(TriAttack.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(RapidSpin.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Whirlpool.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(IcicleSpear.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(RockBlast.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(Brine.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(Avalanche.Instance);
            this._moveList.Add(IceShard.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(RazorShell.Instance);
            this._moveList.Add(Liquidation.Instance);
        }
        #endregion
    }
}