// https://www.pokemon.com/us/pokedex/894

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Electric
{
    internal class Regieleki : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Regieleki()); }
        }
        #endregion
        
        #region Constructors
        private Regieleki()
            : base(
                894,
                "Regieleki",
                "Regieleki",
                TypeElectric.Instance,
                12,
                1450,
                "Electron Pokémon",
                "Pokémon Électron",
                "Its entire body is made up of a single organ that generates electrical energy. Regieleki is capable of creating all Galar’s electricity.",
                "Son corps est entièrement composé d’organes générant de l’électricité. Il peut produire assez d’énergie pour alimenter tout Galar.",
                80,
                100,
                50,
                100,
                50,
                200
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
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(Thrash.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(ThunderShock.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(SelfDestruct.Instance);
            this._moveList.Add(Explosion.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(ZapCannon.Instance);
            this._moveList.Add(RapidSpin.Instance);
            this._moveList.Add(ExtremeSpeed.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(VoltSwitch.Instance);
            this._moveList.Add(Electroweb.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(RisingVoltage.Instance);
            this._moveList.Add(ThunderCage.Instance);
        }
        #endregion
    }
}