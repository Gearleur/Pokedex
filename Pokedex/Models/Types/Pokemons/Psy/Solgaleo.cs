// https://www.pokemon.com/us/pokedex/791

using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Psy
{
    internal class Solgaleo : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Solgaleo()); }
        }
        #endregion
        
        #region Constructors
        private Solgaleo()
            : base(
                791,
                "Solgaleo",
                "Solgaleo",
                TypePsy.Instance,
                TypeSteel.Instance,
                34,
                2300,
                "Sunne Pokémon",
                "Pokémon Halo Solaire",
                "Solgaleo was once known as the Beast That Devours the Sun. Energy in the form of light radiates boundlessly from it.",
                "Jadis, on le surnommait « celui qui dévore le soleil ». Une lumière inextinguible rayonne de son corps.",
                137,
                137,
                107,
                113,
                89,
                97
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
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(FireSpin.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Outrage.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(MetalClaw.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(FutureSight.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(WakeUpSlap.Instance);
            this._moveList.Add(CloseCombat.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(FlareBlitz.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(Psyshock.Instance);
            this._moveList.Add(FlameCharge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(Snarl.Instance);
            this._moveList.Add(MysticalFire.Instance);
            this._moveList.Add(PsychicFangs.Instance);
            this._moveList.Add(SunsteelStrike.Instance);
            this._moveList.Add(SteelBeam.Instance);
            this._moveList.Add(ExpandingForce.Instance);
            this._moveList.Add(SteelRoller.Instance);
            this._moveList.Add(MeteorBeam.Instance);
        }
        #endregion
    }
}