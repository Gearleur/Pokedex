// https://www.pokemon.com/us/pokedex/420

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Cherubi : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Cherubi()); }
        }
        #endregion
        
        #region Constructors
        private Cherubi()
            : base(
                420,
                "Cherubi",
                "Ceribou",
                TypeGrass.Instance,
                4,
                33,
                "Cherry Pokémon",
                "Pokémon Cerise",
                "The deeper a Cherubi’s red, the more nutrients it has stockpiled in its body. And the sweeter and tastier its small ball!",
                "Plus son corps est rouge, plus la saveur de sa petite boule gorgée de nutriments est sucrée et délicieuse.",
                45,
                35,
                45,
                62,
                53,
                35
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
            this._moveList.Add(RazorLeaf.Instance);
            this._moveList.Add(SolarBeam.Instance);
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
            this._moveList.Add(Round.Instance);
            this._moveList.Add(PetalBlizzard.Instance);
            this._moveList.Add(DrainingKiss.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(Leafage.Instance);
            this._moveList.Add(PollenPuff.Instance);
            this._moveList.Add(GrassyGlide.Instance);
        }
        #endregion
    }
}