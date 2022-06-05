// https://www.pokemon.com/us/pokedex/761

using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Bounsweet : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Bounsweet()); }
        }
        #endregion
        
        #region Constructors
        private Bounsweet()
            : base(
                761,
                "Bounsweet",
                "Croquine",
                TypeGrass.Instance,
                3,
                32,
                "Fruit Pokémon",
                "Pokémon Fruit",
                "When under attack, it secretes a sweet and delicious sweat. The scent only calls more enemies to it.",
                "La sueur sucrée qu’il produit lorsqu’on l’attaque est délicieuse. L’odeur de celle-ci lui attire encore plus d’ennemis.",
                42,
                30,
                38,
                30,
                38,
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
            this._moveList.Add(RazorLeaf.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(RapidSpin.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(Feint.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(DrainingKiss.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(GrassyGlide.Instance);
        }
        #endregion
    }
}