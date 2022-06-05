// https://www.pokemon.com/us/pokedex/77

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fire
{
    internal class Ponyta : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Ponyta()); }
        }
        #endregion
        
        #region Constructors
        private Ponyta()
            : base(
                77,
                "Ponyta",
                "Ponyta",
                TypeFire.Instance,
                10,
                300,
                "Fire Horse Pokémon",
                "Pokémon Cheval Feu",
                "If you’ve been accepted by Ponyta, its burning mane is mysteriously no longer hot to the touch.",
                "Il semblerait qu’une fois qu’un Dresseur a gagné la confiance de Ponyta, sa crinière enflammée ne le brûle plus au toucher.",
                50,
                85,
                55,
                65,
                65,
                90
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
            this._moveList.Add(Stomp.Instance);
            this._moveList.Add(DoubleKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(Thrash.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Ember.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(FireSpin.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(Rage.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(SkullBash.Instance);
            this._moveList.Add(FlameWheel.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Overheat.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(FlareBlitz.Instance);
            this._moveList.Add(FlameCharge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(Inferno.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(MysticalFire.Instance);
            this._moveList.Add(HighHorsepower.Instance);
            this._moveList.Add(SolarBlade.Instance);
        }
        #endregion
    }
}