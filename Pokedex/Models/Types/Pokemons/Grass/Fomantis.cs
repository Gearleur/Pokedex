// https://www.pokemon.com/us/pokedex/753

using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Fomantis : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Fomantis()); }
        }
        #endregion
        
        #region Constructors
        private Fomantis()
            : base(
                753,
                "Fomantis",
                "Mimantis",
                TypeGrass.Instance,
                3,
                15,
                "Sickle Grass Pokémon",
                "Pokémon Fauch’Herbe",
                "During the day, Fomantis basks in sunlight and sleeps peacefully. It wakes and moves around at night.",
                "La journée, il dort tranquillement au soleil pour en absorber les rayons. La nuit, il se réveille et vaque à ses occupations.",
                40,
                55,
                35,
                50,
                35,
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
            this._moveList.Add(RazorLeaf.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(LeechLife.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(LeafBlade.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(LeafStorm.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(DualChop.Instance);
            this._moveList.Add(Leafage.Instance);
            this._moveList.Add(GrassyGlide.Instance);
        }
        #endregion
    }
}