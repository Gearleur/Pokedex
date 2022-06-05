// https://www.pokemon.com/us/pokedex/873

using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ice
{
    internal class Frosmoth : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Frosmoth()); }
        }
        #endregion
        
        #region Constructors
        private Frosmoth()
            : base(
                873,
                "Frosmoth",
                "Beldeneige",
                TypeIce.Instance,
                TypeBug.Instance,
                13,
                420,
                "Frost Moth Pokémon",
                "Pokémon Mite Givre",
                "It shows no mercy to any who desecrate fields and mountains. It will fly around on its icy wings, causing a blizzard to chase offenders away.",
                "Sans pitié pour les vandales, il bat ses ailes gelées pour provoquer des blizzards et punir quiconque ose souiller les champs et les collines.",
                70,
                65,
                60,
                125,
                90,
                65
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
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(AuroraBeam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(LeechLife.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(PowderSnow.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(IcicleSpear.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(BugBuzz.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(Avalanche.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(StruggleBug.Instance);
            this._moveList.Add(Hurricane.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(Infestation.Instance);
            this._moveList.Add(SkitterSmack.Instance);
            this._moveList.Add(TripleAxel.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}