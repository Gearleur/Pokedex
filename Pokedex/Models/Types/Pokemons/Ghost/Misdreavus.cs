// https://www.pokemon.com/us/pokedex/200

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ghost
{
    internal class Misdreavus : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Misdreavus()); }
        }
        #endregion
        
        #region Constructors
        private Misdreavus()
            : base(
                200,
                "Misdreavus",
                "Feuforêve",
                TypeGhost.Instance,
                7,
                10,
                "Screech Pokémon",
                "Pokémon Strident",
                "What makes it happy is imitating the voices of weeping people and scaring everyone. It doesn’t deal well with folks who aren’t easily frightened.",
                "Il adore faire peur aux humains en imitant leurs pleurs, et n’apprécie guère ceux qui ne se laissent pas intimider.",
                60,
                60,
                60,
                85,
                85,
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
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Psybeam.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(ZapCannon.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(PowerGem.Instance);
            this._moveList.Add(ShadowSneak.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(OminousWind.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(Hex.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
        }
        #endregion
    }
}