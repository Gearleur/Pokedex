// https://www.pokemon.com/us/pokedex/644

using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Dragon
{
    internal class Zekrom : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Zekrom()); }
        }
        #endregion
        
        #region Constructors
        private Zekrom()
            : base(
                644,
                "Zekrom",
                "Zekrom",
                TypeDragon.Instance,
                TypeElectric.Instance,
                29,
                3450,
                "Deep Black Pokémon",
                "Pokémon Noir Idéal",
                "Mythology tells us that if people lose the righteousness in their hearts, their kingdoms will be razed by Zekrom’s lightning.",
                "Selon la légende, lorsque les gens perdent tout sens de ce qui est juste, Zekrom réduit le pays entier en cendres avec de terribles éclairs.",
                100,
                150,
                120,
                120,
                100,
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
            this._moveList.Add(ThunderPunch.Instance);
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(Fly.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Outrage.Instance);
            this._moveList.Add(SteelWing.Instance);
            this._moveList.Add(DragonBreath.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(DragonClaw.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(ThunderFang.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(DracoMeteor.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(VoltSwitch.Instance);
            this._moveList.Add(DragonTail.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(BoltStrike.Instance);
            this._moveList.Add(FusionBolt.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(BodyPress.Instance);
            this._moveList.Add(BreakingSwipe.Instance);
            this._moveList.Add(ScaleShot.Instance);
            this._moveList.Add(RisingVoltage.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}