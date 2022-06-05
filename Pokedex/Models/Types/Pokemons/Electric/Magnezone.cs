// https://www.pokemon.com/us/pokedex/462

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Electric
{
    internal class Magnezone : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Magnezone()); }
        }
        #endregion
        
        #region Constructors
        private Magnezone()
            : base(
                462,
                "Magnezone",
                "Magnézone",
                TypeElectric.Instance,
                TypeSteel.Instance,
                12,
                1800,
                "Magnet Area Pokémon",
                "Pokémon Aimant",
                "It’s thought that a special magnetic field changed the molecular structure of this Pokémon’s body, and that’s what caused the Pokémon’s evolution.",
                "On pense qu’il a évolué après avoir été exposé à un champ magnétique particulier qui a modifié la structure moléculaire de son corps.",
                70,
                70,
                115,
                130,
                90,
                60
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
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(ThunderShock.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(SelfDestruct.Instance);
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
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(VoltSwitch.Instance);
            this._moveList.Add(Electroweb.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(BodyPress.Instance);
            this._moveList.Add(SteelBeam.Instance);
            this._moveList.Add(SteelRoller.Instance);
            this._moveList.Add(RisingVoltage.Instance);
        }
        #endregion
    }
}