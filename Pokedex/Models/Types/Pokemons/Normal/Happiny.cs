// https://www.pokemon.com/us/pokedex/440

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Happiny : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Happiny()); }
        }
        #endregion
        
        #region Constructors
        private Happiny()
            : base(
                440,
                "Happiny",
                "Ptiravi",
                TypeNormal.Instance,
                6,
                244,
                "Playhouse Pokémon",
                "Pokémon Maisonjouet",
                "Happiny’s willing to lend its precious round stone to those it’s friendly with, but if the stone isn’t returned, Happiny will cry and throw a tantrum.",
                "Il prête volontiers son caillou rond à ceux qu’il apprécie, mais éclate en sanglots et se met en colère si on ne le lui rend pas.",
                100,
                5,
                5,
                15,
                65,
                30
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
            this._moveList.Add(Pound.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(MudBomb.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(Incinerate.Instance);
        }
        #endregion
    }
}