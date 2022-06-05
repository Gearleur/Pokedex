// https://www.pokemon.com/us/pokedex/595

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Joltik : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Joltik()); }
        }
        #endregion
        
        #region Constructors
        private Joltik()
            : base(
                595,
                "Joltik",
                "Statitik",
                TypeBug.Instance,
                TypeElectric.Instance,
                1,
                6,
                "Attaching Pokémon",
                "Pokémon Crampon",
                "Joltik latch on to other Pokémon and suck out static electricity. They’re often found sticking to Yamper’s hindquarters.",
                "Il s’accroche aux autres Pokémon pour aspirer leur électricité statique. On en trouve souvent collés au postérieur de Voltoutou.",
                50,
                47,
                50,
                57,
                50,
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
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(PoisonSting.Instance);
            this._moveList.Add(PinMissile.Instance);
            this._moveList.Add(Absorb.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(LeechLife.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(Pursuit.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(BugBuzz.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(RockClimb.Instance);
            this._moveList.Add(Discharge.Instance);
            this._moveList.Add(CrossPoison.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(VoltSwitch.Instance);
            this._moveList.Add(StruggleBug.Instance);
            this._moveList.Add(Electroweb.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(Infestation.Instance);
            this._moveList.Add(Lunge.Instance);
            this._moveList.Add(RisingVoltage.Instance);
            this._moveList.Add(SkitterSmack.Instance);
        }
        #endregion
    }
}