// https://www.pokemon.com/us/pokedex/251

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Psy
{
    internal class Celebi : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Celebi()); }
        }
        #endregion
        
        #region Constructors
        private Celebi()
            : base(
                251,
                "Celebi",
                "Celebi",
                TypePsy.Instance,
                TypeGrass.Instance,
                6,
                50,
                "Time Travel Pokémon",
                "Pokémon Temporel",
                "This Pokémon traveled through time to come from the future. It bolsters grass and trees with its own strength, and it can heal wounds, too.",
                "Ce Pokémon venu du futur soigne les blessures et donne de la force aux plantes.",
                100,
                100,
                100,
                100,
                100,
                100
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
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Confusion.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(FutureSight.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(SilverWind.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(LeafBlade.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(PsychoCut.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(LeafStorm.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(SolarBlade.Instance);
            this._moveList.Add(PollenPuff.Instance);
            this._moveList.Add(ExpandingForce.Instance);
            this._moveList.Add(GrassyGlide.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}