// https://www.pokemon.com/us/pokedex/825

using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Dottler : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Dottler()); }
        }
        #endregion
        
        #region Constructors
        private Dottler()
            : base(
                825,
                "Dottler",
                "Coléodôme",
                TypeBug.Instance,
                TypePsy.Instance,
                4,
                195,
                "Radome Pokémon",
                "Pokémon Radôme",
                "As it grows inside its shell, it uses its psychic abilities to monitor the outside world and prepare for evolution.",
                "Il se développe dans sa coquille et se prépare à évoluer en sondant les alentours grâce à ses pouvoirs psychiques.",
                50,
                35,
                80,
                50,
                90,
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
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Confusion.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(LeechLife.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(FutureSight.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(BugBuzz.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(Psyshock.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(StruggleBug.Instance);
            this._moveList.Add(BodyPress.Instance);
            this._moveList.Add(ExpandingForce.Instance);
        }
        #endregion
    }
}