// https://www.pokemon.com/us/pokedex/479

using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Electric
{
    internal class Rotom : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Rotom()); }
        }
        #endregion
        
        #region Constructors
        private Rotom()
            : base(
                479,
                "Rotom",
                "Motisma",
                TypeElectric.Instance,
                TypeGhost.Instance,
                3,
                3,
                "Plasma Pokémon",
                "Pokémon Plasma",
                "With a body made of plasma, it can inhabit all sorts of machines. It loves to surprise others.",
                "Son corps composé de plasma lui permet d’infiltrer diverses machines. Il adore surprendre les gens.",
                50,
                50,
                77,
                95,
                77,
                91
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
            this._moveList.Add(ThunderShock.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(Discharge.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(OminousWind.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(Hex.Instance);
            this._moveList.Add(VoltSwitch.Instance);
            this._moveList.Add(Electroweb.Instance);
            this._moveList.Add(RisingVoltage.Instance);
            this._moveList.Add(Poltergeist.Instance);
        }
        #endregion
    }
}