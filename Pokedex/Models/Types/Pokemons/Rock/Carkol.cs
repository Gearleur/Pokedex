// https://www.pokemon.com/us/pokedex/838

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Rock
{
    internal class Carkol : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Carkol()); }
        }
        #endregion
        
        #region Constructors
        private Carkol()
            : base(
                838,
                "Carkol",
                "Wagomine",
                TypeRock.Instance,
                TypeFire.Instance,
                11,
                780,
                "Coal Pokémon",
                "Pokémon Charbon",
                "By rapidly rolling its legs, it can travel at over 18 mph. The temperature of the flames it breathes exceeds 1,800 degrees Fahrenheit.",
                "Il peut faire tourner ses pattes très vite pour se déplacer à une vitesse de 30 km/h. Il peut aussi souffler des flammes à 1 000 °C.",
                80,
                60,
                90,
                60,
                70,
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
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(FireSpin.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(SelfDestruct.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(RapidSpin.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Overheat.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SandTomb.Instance);
            this._moveList.Add(RockBlast.Instance);
            this._moveList.Add(FlareBlitz.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(SmackDown.Instance);
            this._moveList.Add(FlameCharge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(HighHorsepower.Instance);
            this._moveList.Add(BurnUp.Instance);
            this._moveList.Add(BodyPress.Instance);
            this._moveList.Add(MeteorBeam.Instance);
            this._moveList.Add(ScorchingSands.Instance);
        }
        #endregion
    }
}