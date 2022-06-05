// https://www.pokemon.com/us/pokedex/727

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fire
{
    internal class Incineroar : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Incineroar()); }
        }
        #endregion
        
        #region Constructors
        private Incineroar()
            : base(
                727,
                "Incineroar",
                "Félinferno",
                TypeFire.Instance,
                TypeDark.Instance,
                18,
                830,
                "Heel Pokémon",
                "Pokémon Vil Catcheur",
                "Incineroar’s rough and aggressive behavior is its most notable trait, but the way it helps out small Pokémon shows that it has a kind side as well.",
                "Bien qu’il soit parfois brutal, il sait aussi se montrer attentionné en venant en aide aux petits Pokémon.",
                95,
                115,
                90,
                80,
                90,
                60
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
            this._moveList.Add(PayDay.Instance);
            this._moveList.Add(FirePunch.Instance);
            this._moveList.Add(ThunderPunch.Instance);
            this._moveList.Add(Scratch.Instance);
            this._moveList.Add(Bind.Instance);
            this._moveList.Add(DoubleKick.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(Thrash.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Ember.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(FireSpin.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Lick.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(LeechLife.Instance);
            this._moveList.Add(FurySwipes.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Outrage.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(CrossChop.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(FocusPunch.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(BlazeKick.Instance);
            this._moveList.Add(BlastBurn.Instance);
            this._moveList.Add(Overheat.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(CloseCombat.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(FlareBlitz.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(FireFang.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(FlameCharge.Instance);
            this._moveList.Add(LowSweep.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(FirePledge.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(DualChop.Instance);
            this._moveList.Add(Snarl.Instance);
            this._moveList.Add(DarkestLariat.Instance);
            this._moveList.Add(ThroatChop.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(StompingTantrum.Instance);
            this._moveList.Add(BurningJealousy.Instance);
            this._moveList.Add(LashOut.Instance);
            this._moveList.Add(ScorchingSands.Instance);
        }
        #endregion
    }
}