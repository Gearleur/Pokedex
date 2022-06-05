// https://www.pokemon.com/us/pokedex/736

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Grubbin : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Grubbin()); }
        }
        #endregion
        
        #region Constructors
        private Grubbin()
            : base(
                736,
                "Grubbin",
                "Larvibule",
                TypeBug.Instance,
                4,
                44,
                "Larva Pokémon",
                "Pokémon Larve",
                "It uses its big jaws to dig nests into the forest floor, and it loves to feed on sweet tree sap.",
                "Il creuse son terrier dans le sol de la forêt avec ses grandes mandibules. Il raffole de la sève sucrée.",
                47,
                62,
                45,
                55,
                45,
                46
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
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(Spark.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(Discharge.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(VoltSwitch.Instance);
            this._moveList.Add(Electroweb.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(RisingVoltage.Instance);
            this._moveList.Add(SkitterSmack.Instance);
        }
        #endregion
    }
}