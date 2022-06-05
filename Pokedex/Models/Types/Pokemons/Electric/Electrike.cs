// https://www.pokemon.com/us/pokedex/309

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Electric
{
    internal class Electrike : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Electrike()); }
        }
        #endregion
        
        #region Constructors
        private Electrike()
            : base(
                309,
                "Electrike",
                "Dynavolt",
                TypeElectric.Instance,
                6,
                152,
                "Lightning Pokémon",
                "Pokémon Orage",
                "It stores electricity in its fur. It gives off sparks from all over its body in seasons when the air is dry.",
                "L’électricité statique s’accumule dans sa fourrure. Par temps sec, elle dégage des étincelles.",
                40,
                45,
                40,
                65,
                40,
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
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(Spark.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(ThunderFang.Instance);
            this._moveList.Add(IceFang.Instance);
            this._moveList.Add(FireFang.Instance);
            this._moveList.Add(Discharge.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(FlameBurst.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(VoltSwitch.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(Snarl.Instance);
            this._moveList.Add(PsychicFangs.Instance);
            this._moveList.Add(RisingVoltage.Instance);
        }
        #endregion
    }
}