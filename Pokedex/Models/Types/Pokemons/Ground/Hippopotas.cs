// https://www.pokemon.com/us/pokedex/449

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ground
{
    internal class Hippopotas : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Hippopotas()); }
        }
        #endregion
        
        #region Constructors
        private Hippopotas()
            : base(
                449,
                "Hippopotas",
                "Hippopotas",
                TypeGround.Instance,
                8,
                495,
                "Hippo Pokémon",
                "Pokémon Hippo",
                "This Pokémon is active during the day and passes the cold desert nights burrowed snugly into the sand.",
                "Il est principalement actif pendant la journée. Il s’enfouit profondément dans le sable pour dormir, car les nuits désertiques sont très froides.",
                68,
                72,
                78,
                38,
                42,
                32
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
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SandTomb.Instance);
            this._moveList.Add(MuddyWater.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(HighHorsepower.Instance);
            this._moveList.Add(StompingTantrum.Instance);
            this._moveList.Add(ScorchingSands.Instance);
        }
        #endregion
    }
}