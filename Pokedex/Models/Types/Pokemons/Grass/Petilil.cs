// https://www.pokemon.com/us/pokedex/548

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Petilil : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Petilil()); }
        }
        #endregion
        
        #region Constructors
        private Petilil()
            : base(
                548,
                "Petilil",
                "Chlorobule",
                TypeGrass.Instance,
                5,
                66,
                "Bulb Pokémon",
                "Pokémon Racine",
                "The deeper the color of a Petilil’s leaves, the healthier the Pokémon is. Petilil sometimes makes its home in a well-tended field or flowerbed.",
                "Plus ses feuilles sont foncées, plus il est en bonne santé. Il s’installe parfois dans les champs ou les parterres de fleurs bien entretenus.",
                45,
                35,
                50,
                70,
                50,
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
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(Absorb.Instance);
            this._moveList.Add(MegaDrain.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(LeafStorm.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(PollenPuff.Instance);
            this._moveList.Add(GrassyGlide.Instance);
        }
        #endregion
    }
}