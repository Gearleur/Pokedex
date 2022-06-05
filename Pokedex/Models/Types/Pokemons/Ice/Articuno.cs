// https://www.pokemon.com/us/pokedex/144

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ice
{
    internal class Articuno : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Articuno()); }
        }
        #endregion
        
        #region Constructors
        private Articuno()
            : base(
                144,
                "Articuno",
                "Artikodin",
                TypeIce.Instance,
                TypeFlying.Instance,
                17,
                554,
                "Freeze Pokémon",
                "Pokémon Glaciaire",
                "This Pokémon can control ice at will. Articuno is said to live in snowy mountains riddled with permafrost.",
                "Il possède le pouvoir de contrôler la glace. Selon les dires, il vivrait sur les sommets recouverts de neiges éternelles.",
                90,
                85,
                100,
                95,
                125,
                85
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
            this._moveList.Add(RazorWind.Instance);
            this._moveList.Add(Gust.Instance);
            this._moveList.Add(Fly.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(BubbleBeam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(Rage.Instance);
            this._moveList.Add(SkyAttack.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(PowderSnow.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(SteelWing.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Twister.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(AirCutter.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(IcicleSpear.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(Pluck.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(BraveBird.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(Avalanche.Instance);
            this._moveList.Add(IceShard.Instance);
            this._moveList.Add(OminousWind.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(SkyDrop.Instance);
            this._moveList.Add(FrostBreath.Instance);
            this._moveList.Add(Hurricane.Instance);
            this._moveList.Add(FreezeDry.Instance);
            this._moveList.Add(TripleAxel.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}