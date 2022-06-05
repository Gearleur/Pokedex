// https://www.pokemon.com/us/pokedex/431

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Glameow : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Glameow()); }
        }
        #endregion
        
        #region Constructors
        private Glameow()
            : base(
                431,
                "Glameow",
                "Chaglam",
                TypeNormal.Instance,
                5,
                39,
                "Catty Pokémon",
                "Pokémon Chafouin",
                "When it’s happy, Glameow demonstrates beautiful movements of its tail, like a dancing ribbon.",
                "Lorsqu’il est heureux, sa queue décrit des arabesques comme un ruban de gymnastique rythmique.",
                49,
                55,
                42,
                42,
                37,
                85
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
            this._moveList.Add(Scratch.Instance);
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(FurySwipes.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(FakeOut.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(WakeUpSlap.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(PlayRough.Instance);
        }
        #endregion
    }
}