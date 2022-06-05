// https://www.pokemon.com/us/pokedex/829

using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Gossifleur : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Gossifleur()); }
        }
        #endregion
        
        #region Constructors
        private Gossifleur()
            : base(
                829,
                "Gossifleur",
                "Tournicoton",
                TypeGrass.Instance,
                4,
                22,
                "Flowering Pokémon",
                "Pokémon Chef-Fleur",
                "It whirls around in the wind while singing a joyous song. This delightful display has charmed many into raising this Pokémon.",
                "Nombreux sont ceux qui ont décidé d’en élever un après avoir été charmés par sa manière de chanter en virevoltant au gré de la brise.",
                40,
                40,
                60,
                40,
                60,
                10
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
            this._moveList.Add(RazorLeaf.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(RapidSpin.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(EnergyBall.Instance);
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