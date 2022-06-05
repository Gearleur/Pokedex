// https://www.pokemon.com/us/pokedex/796

using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Electric
{
    internal class Xurkitree : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Xurkitree()); }
        }
        #endregion
        
        #region Constructors
        private Xurkitree()
            : base(
                796,
                "Xurkitree",
                "Câblifère",
                TypeElectric.Instance,
                38,
                1000,
                "Glowing Pokémon",
                "Pokémon Luminaire",
                "They’ve been dubbed Ultra Beasts. Some of them stand unmoving, like trees, with their arms and legs stuck into the ground.",
                "Certains spécimens de ce type d’Ultra-Chimère plantent leurs membres dans le sol à la manière d’un arbre et restent immobiles.",
                83,
                89,
                71,
                173,
                71,
                83
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
            this._moveList.Add(Bind.Instance);
            this._moveList.Add(Wrap.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(ThunderShock.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(ZapCannon.Instance);
            this._moveList.Add(Spark.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(Discharge.Instance);
            this._moveList.Add(PowerWhip.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(VoltSwitch.Instance);
            this._moveList.Add(Electroweb.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(RisingVoltage.Instance);
        }
        #endregion
    }
}