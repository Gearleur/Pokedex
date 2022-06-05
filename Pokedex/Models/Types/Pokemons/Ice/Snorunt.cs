// https://www.pokemon.com/us/pokedex/361

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ice
{
    internal class Snorunt : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Snorunt()); }
        }
        #endregion
        
        #region Constructors
        private Snorunt()
            : base(
                361,
                "Snorunt",
                "Stalgamin",
                TypeIce.Instance,
                7,
                168,
                "Snow Hat Pokémon",
                "Pokémon Capuche",
                "It can only survive in cold areas. It bounces happily around, even in environments as cold as −150 degrees Fahrenheit.",
                "Il ne peut vivre que dans les plus froides contrées. Il s’accommode parfaitement de températures atteignant les - 100 °C.",
                50,
                50,
                50,
                50,
                50,
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
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(PowderSnow.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(Avalanche.Instance);
            this._moveList.Add(IceShard.Instance);
            this._moveList.Add(IceFang.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Hex.Instance);
            this._moveList.Add(FrostBreath.Instance);
            this._moveList.Add(IcicleCrash.Instance);
        }
        #endregion
    }
}