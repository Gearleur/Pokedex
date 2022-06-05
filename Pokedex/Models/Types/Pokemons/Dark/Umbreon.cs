// https://www.pokemon.com/us/pokedex/197

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Dark
{
    internal class Umbreon : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Umbreon()); }
        }
        #endregion
        
        #region Constructors
        private Umbreon()
            : base(
                197,
                "Umbreon",
                "Noctali",
                TypeDark.Instance,
                10,
                270,
                "Moonlight Pokémon",
                "Pokémon Lune",
                "On the night of a full moon, or when it gets excited, the ring patterns on its body glow yellow.",
                "Les nuits de pleine lune, ou s’il est agité, les anneaux sur sa peau se mettent à briller.",
                95,
                65,
                110,
                60,
                130,
                65
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
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(ZapCannon.Instance);
            this._moveList.Add(Pursuit.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(Snarl.Instance);
            this._moveList.Add(ThroatChop.Instance);
            this._moveList.Add(LashOut.Instance);
        }
        #endregion
    }
}