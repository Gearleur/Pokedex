// https://www.pokemon.com/us/pokedex/826

using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Orbeetle : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Orbeetle()); }
        }
        #endregion
        
        #region Constructors
        private Orbeetle()
            : base(
                826,
                "Orbeetle",
                "Astronelle",
                TypeBug.Instance,
                TypePsy.Instance,
                4,
                408,
                "Seven Spot Pokémon",
                "Pokémon Sept Points",
                "It emits psychic energy to observe and study what’s around it—and what’s around it can include things over six miles away.",
                "Il déploie ses pouvoirs psychiques pour sonder les alentours, sur un rayon pouvant atteindre 10 km.",
                60,
                45,
                110,
                80,
                120,
                90
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
            this._moveList.Add(Psybeam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Confusion.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(LeechLife.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(FutureSight.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(BugBuzz.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(PsychoCut.Instance);
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