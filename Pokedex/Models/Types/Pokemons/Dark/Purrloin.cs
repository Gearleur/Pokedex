// https://www.pokemon.com/us/pokedex/509

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Dark
{
    internal class Purrloin : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Purrloin()); }
        }
        #endregion
        
        #region Constructors
        private Purrloin()
            : base(
                509,
                "Purrloin",
                "Chacripan",
                TypeDark.Instance,
                4,
                101,
                "Devious Pokémon",
                "Pokémon Scélérat",
                "Opponents that get drawn in by its adorable behavior come away with stinging scratches from its claws and stinging pride from its laughter.",
                "Malheur à qui se laisse berner par ses gestes adorables : une fois les gens à sa portée, il les griffe sans crier gare, en ricanant.",
                41,
                50,
                37,
                50,
                37,
                66
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
            this._moveList.Add(PayDay.Instance);
            this._moveList.Add(Scratch.Instance);
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(FurySwipes.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Pursuit.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(FakeOut.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(NightSlash.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(GunkShot.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(Snarl.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(LashOut.Instance);
        }
        #endregion
    }
}