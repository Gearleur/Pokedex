// https://www.pokemon.com/us/pokedex/315

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Roselia : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Roselia()); }
        }
        #endregion
        
        #region Constructors
        private Roselia()
            : base(
                315,
                "Roselia",
                "Rosélia",
                TypeGrass.Instance,
                TypePoison.Instance,
                3,
                20,
                "Thorn Pokémon",
                "Pokémon Épine",
                "It uses the different poisons in each hand separately when it attacks. The stronger its aroma, the healthier it is.",
                "Ses mains sécrètent chacune un poison différent dont il se sert pour attaquer. Plus le parfum de Rosélia est intense, plus sa santé est bonne.",
                50,
                60,
                45,
                100,
                80,
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
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(PoisonSting.Instance);
            this._moveList.Add(PinMissile.Instance);
            this._moveList.Add(Absorb.Instance);
            this._moveList.Add(MegaDrain.Instance);
            this._moveList.Add(RazorLeaf.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(PetalDance.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(Extrasensory.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(LeafStorm.Instance);
            this._moveList.Add(PowerWhip.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(PetalBlizzard.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(GrassyGlide.Instance);
        }
        #endregion
    }
}