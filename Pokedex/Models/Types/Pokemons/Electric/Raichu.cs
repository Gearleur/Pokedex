// https://www.pokemon.com/us/pokedex/26

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Electric
{
    internal class Raichu : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Raichu()); }
        }
        #endregion
        
        #region Constructors
        private Raichu()
            : base(
                26,
                "Raichu",
                "Raichu",
                TypeElectric.Instance,
                8,
                300,
                "Mouse Pokémon",
                "Pokémon Souris",
                "If its electric pouches run empty, it raises its tail to gather electricity from the atmosphere.",
                "Si ses joues sont à court d’énergie, il lève la queue et capte l’électricité contenue dans l’atmosphère.",
                60,
                90,
                55,
                90,
                80,
                110
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
            this._moveList.Add(ThunderPunch.Instance);
            this._moveList.Add(Slam.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Submission.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(ThunderShock.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(Rage.Instance);
            this._moveList.Add(SkullBash.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(ZapCannon.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(Spark.Instance);
            this._moveList.Add(DynamicPunch.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(FakeOut.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(FocusPunch.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(Feint.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(Discharge.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(VoltSwitch.Instance);
            this._moveList.Add(Electroweb.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(DrainingKiss.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(Nuzzle.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(RisingVoltage.Instance);
        }
        #endregion
    }
}