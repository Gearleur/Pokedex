// https://www.pokemon.com/us/pokedex/871

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Electric
{
    internal class Pincurchin : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Pincurchin()); }
        }
        #endregion
        
        #region Constructors
        private Pincurchin()
            : base(
                871,
                "Pincurchin",
                "Wattapik",
                TypeElectric.Instance,
                3,
                10,
                "Sea Urchin Pokémon",
                "Pokémon Oursin",
                "It stores electricity in each spine. Even if one gets broken off, it still continues to emit electricity for at least three hours.",
                "Chacune de ses épines est chargée en électricité. S’il en perd une, celle-ci continue d’émettre un courant électrique pendant trois heures.",
                48,
                101,
                95,
                91,
                85,
                15
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
            this._moveList.Add(FuryAttack.Instance);
            this._moveList.Add(PinMissile.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(BubbleBeam.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(ThunderShock.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(SelfDestruct.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Spark.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(MuddyWater.Instance);
            this._moveList.Add(Brine.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(Discharge.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Hex.Instance);
            this._moveList.Add(ThroatChop.Instance);
            this._moveList.Add(Liquidation.Instance);
            this._moveList.Add(ZingZap.Instance);
            this._moveList.Add(RisingVoltage.Instance);
        }
        #endregion
    }
}