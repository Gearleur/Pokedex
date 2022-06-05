// https://www.pokemon.com/us/pokedex/430

using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Dark
{
    internal class Honchkrow : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Honchkrow()); }
        }
        #endregion
        
        #region Constructors
        private Honchkrow()
            : base(
                430,
                "Honchkrow",
                "Corboss",
                TypeDark.Instance,
                TypeFlying.Instance,
                9,
                273,
                "Big Boss Pokémon",
                "Pokémon Big Boss",
                "Its goons take care of most of the fighting for it. The only time it dirties its own hands is in delivering a final blow to finish off an opponent.",
                "Ses sous-fifres font le sale boulot pour lui. Il n’intervient en combat que pour donner le coup de grâce à son ennemi.",
                100,
                125,
                52,
                105,
                52,
                71
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
            this._moveList.Add(WingAttack.Instance);
            this._moveList.Add(Fly.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(SkyAttack.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(SteelWing.Instance);
            this._moveList.Add(Pursuit.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Twister.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(AirCutter.Instance);
            this._moveList.Add(Pluck.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(NightSlash.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(OminousWind.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(Snarl.Instance);
        }
        #endregion
    }
}