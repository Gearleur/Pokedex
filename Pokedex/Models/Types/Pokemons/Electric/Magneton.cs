// https://www.pokemon.com/us/pokedex/82

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Electric
{
    internal class Magneton : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Magneton()); }
        }
        #endregion
        
        #region Constructors
        private Magneton()
            : base(
                82,
                "Magneton",
                "Magnéton",
                TypeElectric.Instance,
                TypeSteel.Instance,
                10,
                600,
                "Magnet Pokémon",
                "Pokémon Magnétique",
                "This Pokémon is constantly putting out a powerful magnetic force. Most computers go haywire when a Magneton approaches.",
                "Il émet constamment une énergie magnétique puissante qui interfère avec la grande majorité des ordinateurs dont il s’approche.",
                50,
                60,
                95,
                120,
                70,
                70
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
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(ThunderShock.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Rage.Instance);
            this._moveList.Add(Explosion.Instance);
            this._moveList.Add(TriAttack.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(ZapCannon.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(Spark.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(MirrorShot.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(Discharge.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(VoltSwitch.Instance);
            this._moveList.Add(Electroweb.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(SteelBeam.Instance);
            this._moveList.Add(RisingVoltage.Instance);
        }
        #endregion
    }
}