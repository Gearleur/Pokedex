// https://www.pokemon.com/us/pokedex/850

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fire
{
    internal class Sizzlipede : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Sizzlipede()); }
        }
        #endregion
        
        #region Constructors
        private Sizzlipede()
            : base(
                850,
                "Sizzlipede",
                "Grillepattes",
                TypeFire.Instance,
                TypeBug.Instance,
                7,
                10,
                "Radiator Pokémon",
                "Pokémon Calorifère",
                "It wraps prey up with its heated body, cooking them in its coils. Once they’re well-done, it will voraciously nibble them down to the last morsel.",
                "Il enserre fermement ses proies avec son corps brûlant et, quand elles sont bien grillées, il les dévore.",
                50,
                65,
                45,
                50,
                50,
                45
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
            this._moveList.Add(FireSpin.Instance);
            this._moveList.Add(LeechLife.Instance);
            this._moveList.Add(FlameWheel.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(BugBuzz.Instance);
            this._moveList.Add(PowerWhip.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(StruggleBug.Instance);
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