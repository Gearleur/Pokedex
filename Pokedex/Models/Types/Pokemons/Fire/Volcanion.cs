// https://www.pokemon.com/us/pokedex/721

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fire
{
    internal class Volcanion : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Volcanion()); }
        }
        #endregion
        
        #region Constructors
        private Volcanion()
            : base(
                721,
                "Volcanion",
                "Volcanion",
                TypeFire.Instance,
                TypeWater.Instance,
                17,
                1950,
                "Steam Pokémon",
                "Pokémon Vapeur",
                "It expels its internal steam from the arms on its back. It has enough power to blow away a mountain.",
                "Il évacue la vapeur qui s’accumule à l’intérieur de son corps par les bras situés sur son dos. Ce jet est assez puissant pour raser des montagnes.",
                80,
                110,
                120,
                130,
                90,
                70
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
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(Stomp.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(FireSpin.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(SelfDestruct.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(Explosion.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(Overheat.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(FlareBlitz.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ThunderFang.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(SmackDown.Instance);
            this._moveList.Add(SludgeWave.Instance);
            this._moveList.Add(FlameCharge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(SteamEruption.Instance);
            this._moveList.Add(StompingTantrum.Instance);
            this._moveList.Add(Liquidation.Instance);
            this._moveList.Add(BodyPress.Instance);
            this._moveList.Add(ScorchingSands.Instance);
        }
        #endregion
    }
}