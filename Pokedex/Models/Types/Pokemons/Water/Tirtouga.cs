// https://www.pokemon.com/us/pokedex/564

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Tirtouga : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Tirtouga()); }
        }
        #endregion
        
        #region Constructors
        private Tirtouga()
            : base(
                564,
                "Tirtouga",
                "Carapagos",
                TypeWater.Instance,
                TypeRock.Instance,
                7,
                165,
                "Prototurtle Pokémon",
                "Pokémon Tortantique",
                "Tirtouga is considered to be the ancestor of many turtle Pokémon. It was restored to life from a fossil.",
                "Ancêtre présumé de nombreuses espèces de Pokémon tortues, il a été restauré à partir d’un fossile.",
                54,
                78,
                103,
                53,
                45,
                22
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
            this._moveList.Add(Slam.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(RockThrow.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Whirlpool.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(MuddyWater.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(RockBlast.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(Brine.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(AquaJet.Instance);
            this._moveList.Add(SmackDown.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(Liquidation.Instance);
            this._moveList.Add(MeteorBeam.Instance);
        }
        #endregion
    }
}