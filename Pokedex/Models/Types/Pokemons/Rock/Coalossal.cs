// https://www.pokemon.com/us/pokedex/839

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Rock
{
    internal class Coalossal : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Coalossal()); }
        }
        #endregion
        
        #region Constructors
        private Coalossal()
            : base(
                839,
                "Coalossal",
                "Monthracite",
                TypeRock.Instance,
                TypeFire.Instance,
                28,
                3105,
                "Coal Pokémon",
                "Pokémon Charbon",
                "While it’s engaged in battle, its mountain of coal will burn bright red, sending off sparks that scorch the surrounding area.",
                "Lorsqu’il s’engage dans un combat, son tas de charbon brûle et vire au rouge, ce qui répand de petites étincelles qui calcinent ce qui l’entoure.",
                110,
                80,
                120,
                80,
                90,
                30
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
            this._moveList.Add(MegaPunch.Instance);
            this._moveList.Add(FirePunch.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(FireSpin.Instance);
            this._moveList.Add(Earthquake.Instance);
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
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(SmackDown.Instance);
            this._moveList.Add(FlameCharge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(HighHorsepower.Instance);
            this._moveList.Add(BurnUp.Instance);
            this._moveList.Add(BodyPress.Instance);
            this._moveList.Add(MeteorBeam.Instance);
            this._moveList.Add(ScorchingSands.Instance);
        }
        #endregion
    }
}