// https://www.pokemon.com/us/pokedex/600

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Steel
{
    internal class Klang : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Klang()); }
        }
        #endregion
        
        #region Constructors
        private Klang()
            : base(
                600,
                "Klang",
                "Clic",
                TypeSteel.Instance,
                6,
                510,
                "Gear Pokémon",
                "Pokémon Engrenage",
                "Many companies in the Galar region choose Klang as their logo. This Pokémon is considered the symbol of industrial technology.",
                "Ce Pokémon symbolisant la technologie industrielle est souvent utilisé dans le logo des entreprises de Galar.",
                60,
                80,
                95,
                70,
                85,
                50
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
            this._moveList.Add(ViceGrip.Instance);
            this._moveList.Add(Bind.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(ThunderShock.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(ZapCannon.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(PowerGem.Instance);
            this._moveList.Add(MirrorShot.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(Discharge.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(VoltSwitch.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(GearGrind.Instance);
            this._moveList.Add(SteelBeam.Instance);
            this._moveList.Add(SteelRoller.Instance);
            this._moveList.Add(RisingVoltage.Instance);
        }
        #endregion
    }
}