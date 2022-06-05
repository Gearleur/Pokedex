// https://www.pokemon.com/us/pokedex/849

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Electric
{
    internal class ToxtricityAmped : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new ToxtricityAmped()); }
        }
        #endregion
        
        #region Constructors
        private ToxtricityAmped()
            : base(
                849,
                "Toxtricity",
                "Salarsen",
                TypeElectric.Instance,
                TypePoison.Instance,
                16,
                400,
                "Punk Pokémon",
                "Pokémon Punk",
                "This short-tempered and aggressive Pokémon chugs stagnant water to absorb any toxins it might contain.",
                "Impatient et bagarreur, ce Pokémon avale de grandes gorgées d’eau croupie pour en absorber toute la toxicité.",
                75,
                98,
                70,
                114,
                70,
                75
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
            this._moveList.Add(MegaPunch.Instance);
            this._moveList.Add(FirePunch.Instance);
            this._moveList.Add(ThunderPunch.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Acid.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(ThunderShock.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(Spark.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(Discharge.Instance);
            this._moveList.Add(GunkShot.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(SludgeWave.Instance);
            this._moveList.Add(AcidSpray.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(Hex.Instance);
            this._moveList.Add(VoltSwitch.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(Snarl.Instance);
            this._moveList.Add(Belch.Instance);
            this._moveList.Add(Boomburst.Instance);
            this._moveList.Add(Nuzzle.Instance);
            this._moveList.Add(ThroatChop.Instance);
            this._moveList.Add(Overdrive.Instance);
            this._moveList.Add(RisingVoltage.Instance);
        }
        #endregion
    }
}