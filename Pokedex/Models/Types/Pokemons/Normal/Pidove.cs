// https://www.pokemon.com/us/pokedex/519

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Pidove : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Pidove()); }
        }
        #endregion
        
        #region Constructors
        private Pidove()
            : base(
                519,
                "Pidove",
                "Poichigeon",
                TypeNormal.Instance,
                TypeFlying.Instance,
                3,
                21,
                "Tiny Pigeon Pokémon",
                "Pokémon Tipigeon",
                "It’s forgetful and not very bright, but many Trainers love it anyway for its friendliness and sincerity.",
                "Il n’est pas très malin et un peu distrait, mais beaucoup de Dresseurs l’apprécient pour son caractère affectueux et sa bonne volonté.",
                50,
                55,
                50,
                36,
                30,
                43
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
            this._moveList.Add(RazorWind.Instance);
            this._moveList.Add(Gust.Instance);
            this._moveList.Add(Fly.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(SkyAttack.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SteelWing.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(AirCutter.Instance);
            this._moveList.Add(Pluck.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(NightSlash.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}