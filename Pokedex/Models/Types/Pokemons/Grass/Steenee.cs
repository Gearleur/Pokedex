// https://www.pokemon.com/us/pokedex/762

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Steenee : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Steenee()); }
        }
        #endregion
        
        #region Constructors
        private Steenee()
            : base(
                762,
                "Steenee",
                "Candine",
                TypeGrass.Instance,
                7,
                82,
                "Fruit Pokémon",
                "Pokémon Fruit",
                "Any Corvisquire that pecks at this Pokémon will be greeted with a smack from its sepals followed by a sharp kick.",
                "Lorsqu’un Bleuseille le picore, il commence par se défendre avec son calice, et lui assène ensuite de violents coups de pied.",
                52,
                40,
                48,
                40,
                48,
                62
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
            this._moveList.Add(DoubleSlap.Instance);
            this._moveList.Add(Stomp.Instance);
            this._moveList.Add(RazorLeaf.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(RapidSpin.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(LeafStorm.Instance);
            this._moveList.Add(LowSweep.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(DrainingKiss.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(GrassyGlide.Instance);
            this._moveList.Add(TripleAxel.Instance);
        }
        #endregion
    }
}