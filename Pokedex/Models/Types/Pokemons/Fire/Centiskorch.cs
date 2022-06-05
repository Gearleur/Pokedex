// https://www.pokemon.com/us/pokedex/851

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fire
{
    internal class Centiskorch : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Centiskorch()); }
        }
        #endregion
        
        #region Constructors
        private Centiskorch()
            : base(
                851,
                "Centiskorch",
                "Scolocendre",
                TypeFire.Instance,
                TypeBug.Instance,
                30,
                1200,
                "Radiator Pokémon",
                "Pokémon Calorifère",
                "While its burning body is already dangerous on its own, this excessively hostile Pokémon also has large and very sharp fangs.",
                "Il est de nature agressive. Non seulement son corps brûlant est dangereux, mais il possède en plus d’énormes crocs très pointus.",
                100,
                115,
                65,
                90,
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
            this._moveList.Add(Slam.Instance);
            this._moveList.Add(Wrap.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Ember.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(FireSpin.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(LeechLife.Instance);
            this._moveList.Add(FlameWheel.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Overheat.Instance);
            this._moveList.Add(FlareBlitz.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(BugBuzz.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ThunderFang.Instance);
            this._moveList.Add(FireFang.Instance);
            this._moveList.Add(PowerWhip.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Inferno.Instance);
            this._moveList.Add(MysticalFire.Instance);
            this._moveList.Add(Lunge.Instance);
            this._moveList.Add(FireLash.Instance);
            this._moveList.Add(BurnUp.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(SkitterSmack.Instance);
            this._moveList.Add(ScorchingSands.Instance);
        }
        #endregion
    }
}