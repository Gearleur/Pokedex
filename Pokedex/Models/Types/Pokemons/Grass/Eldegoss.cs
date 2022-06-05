// https://www.pokemon.com/us/pokedex/830

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Eldegoss : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Eldegoss()); }
        }
        #endregion
        
        #region Constructors
        private Eldegoss()
            : base(
                830,
                "Eldegoss",
                "Blancoton",
                TypeGrass.Instance,
                5,
                25,
                "Cotton Bloom Pokémon",
                "Pokémon Chef-Coton",
                "The cotton on the head of this Pokémon can be spun into a glossy, gorgeous yarn—a Galar regional specialty.",
                "Les fils tissés à partir du duvet sur sa tête sont satinés et absolument somptueux. Le textile ainsi créé est typique de la région de Galar.",
                60,
                50,
                90,
                80,
                120,
                60
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
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(RazorLeaf.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(RapidSpin.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(LeafStorm.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(LeafTornado.Instance);
            this._moveList.Add(Leafage.Instance);
            this._moveList.Add(PollenPuff.Instance);
            this._moveList.Add(GrassyGlide.Instance);
        }
        #endregion
    }
}