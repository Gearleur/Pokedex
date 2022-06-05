// https://www.pokemon.com/us/pokedex/421

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Cherrim : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Cherrim()); }
        }
        #endregion
        
        #region Constructors
        private Cherrim()
            : base(
                421,
                "Cherrim",
                "Ceriflor",
                TypeGrass.Instance,
                5,
                93,
                "Blossom Pokémon",
                "Pokémon Floraison",
                "Its folded petals are pretty tough. Bird Pokémon can peck at them all they want, and Cherrim won’t be bothered at all.",
                "Lorsqu’il se ferme, ses pétales sont si durs qu’il ne craint plus les attaques des Pokémon oiseaux.",
                70,
                60,
                70,
                87,
                78,
                85
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
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(PetalDance.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(PetalBlizzard.Instance);
            this._moveList.Add(DrainingKiss.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(SolarBlade.Instance);
            this._moveList.Add(Leafage.Instance);
            this._moveList.Add(PollenPuff.Instance);
            this._moveList.Add(GrassyGlide.Instance);
        }
        #endregion
    }
}