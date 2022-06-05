// https://www.pokemon.com/us/pokedex/405

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Electric
{
    internal class Luxray : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Luxray()); }
        }
        #endregion
        
        #region Constructors
        private Luxray()
            : base(
                405,
                "Luxray",
                "Luxray",
                TypeElectric.Instance,
                14,
                420,
                "Gleam Eyes Pokémon",
                "Pokémon Brillœil",
                "Seeing through solid objects uses up a lot of Luxray’s electricity, so the Pokémon sleeps for long periods of time to store up energy.",
                "Il dort beaucoup pour récupérer la quantité d’énergie électrique énorme qu’il consomme afin de voir à travers la matière.",
                80,
                120,
                79,
                95,
                79,
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
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(ThunderShock.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(Spark.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ThunderFang.Instance);
            this._moveList.Add(IceFang.Instance);
            this._moveList.Add(FireFang.Instance);
            this._moveList.Add(Discharge.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(VoltSwitch.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(Snarl.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(ThroatChop.Instance);
            this._moveList.Add(PsychicFangs.Instance);
            this._moveList.Add(RisingVoltage.Instance);
        }
        #endregion
    }
}