// https://www.pokemon.com/us/pokedex/642

using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Electric
{
    internal class ThundurusIncarnate : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new ThundurusIncarnate()); }
        }
        #endregion
        
        #region Constructors
        private ThundurusIncarnate()
            : base(
                642,
                "Thundurus",
                "Fulguris",
                TypeElectric.Instance,
                TypeFlying.Instance,
                15,
                610,
                "Bolt Strike Pokémon",
                "Pokémon Foudroyeur",
                "As it flies around, it shoots lightning all over the place and causes forest fires. It is therefore disliked.",
                "Il vole dans le ciel d’Unys et fait tomber des éclairs, provoquant des incendies qui font sa mauvaise réputation.",
                79,
                115,
                70,
                125,
                80,
                111
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
            this._moveList.Add(Fly.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(Thrash.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(ThunderShock.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(HammerArm.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(Discharge.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(SmackDown.Instance);
            this._moveList.Add(SludgeWave.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(SkyDrop.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(VoltSwitch.Instance);
            this._moveList.Add(Electroweb.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(RisingVoltage.Instance);
            this._moveList.Add(LashOut.Instance);
        }
        #endregion
    }
}