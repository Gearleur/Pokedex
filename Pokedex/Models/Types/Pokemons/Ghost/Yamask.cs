// https://www.pokemon.com/us/pokedex/562

using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ghost
{
    internal class Yamask : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Yamask()); }
        }
        #endregion
        
        #region Constructors
        private Yamask()
            : base(
                562,
                "Yamask",
                "Tutafeh",
                TypeGhost.Instance,
                5,
                15,
                "Spirit Pokémon",
                "Pokémon Âme",
                "The spirit of a person from a bygone age became this Pokémon. It rambles through ruins, searching for someone who knows its face.",
                "Il est né de l’âme d’un être humain d’un peuple antique. Il erre dans les ruines à la recherche de quiconque reconnaîtra son visage.",
                38,
                30,
                85,
                55,
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
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(OminousWind.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Hex.Instance);
            this._moveList.Add(Infestation.Instance);
            this._moveList.Add(Poltergeist.Instance);
        }
        #endregion
    }
}