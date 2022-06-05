// https://www.pokemon.com/us/pokedex/126

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fire
{
    internal class Magmar : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Magmar()); }
        }
        #endregion
        
        #region Constructors
        private Magmar()
            : base(
                126,
                "Magmar",
                "Magmar",
                TypeFire.Instance,
                13,
                445,
                "Spitfire Pokémon",
                "Pokémon Crache-Feu",
                "These Pokémon’s bodies are constantly burning. Magmar are feared as one of the causes behind fires.",
                "Tout son corps est en combustion permanente. Il est craint, car on dit qu’il cause des incendies.",
                65,
                95,
                57,
                100,
                85,
                93
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
            this._moveList.Add(MegaPunch.Instance);
            this._moveList.Add(FirePunch.Instance);
            this._moveList.Add(ThunderPunch.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Ember.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Submission.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(FireSpin.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(Rage.Instance);
            this._moveList.Add(Smog.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(SkullBash.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(FlameWheel.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(DynamicPunch.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(FocusPunch.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Overheat.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(FlareBlitz.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(RockClimb.Instance);
            this._moveList.Add(LavaPlume.Instance);
            this._moveList.Add(FlameBurst.Instance);
            this._moveList.Add(FlameCharge.Instance);
            this._moveList.Add(LowSweep.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(DualChop.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
            this._moveList.Add(BurningJealousy.Instance);
            this._moveList.Add(ScorchingSands.Instance);
        }
        #endregion
    }
}