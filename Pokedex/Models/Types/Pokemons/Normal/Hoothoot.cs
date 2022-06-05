// https://www.pokemon.com/us/pokedex/163

using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Hoothoot : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Hoothoot()); }
        }
        #endregion
        
        #region Constructors
        private Hoothoot()
            : base(
                163,
                "Hoothoot",
                "Hoothoot",
                TypeNormal.Instance,
                TypeFlying.Instance,
                7,
                212,
                "Owl Pokémon",
                "Pokémon Hibou",
                "It begins to hoot at the same time every day. Some Trainers use them in place of clocks.",
                "Il hulule chaque jour aux mêmes moments. Certains Dresseurs s’en servent comme d’une montre.",
                60,
                30,
                30,
                36,
                56,
                50
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
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(Confusion.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(SkyAttack.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(SteelWing.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Twister.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(AirCutter.Instance);
            this._moveList.Add(SilverWind.Instance);
            this._moveList.Add(Extrasensory.Instance);
            this._moveList.Add(Pluck.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(OminousWind.Instance);
            this._moveList.Add(Synchronoise.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(Hurricane.Instance);
            this._moveList.Add(Moonblast.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}