// https://www.pokemon.com/us/pokedex/822

using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Flying
{
    internal class Corvisquire : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Corvisquire()); }
        }
        #endregion
        
        #region Constructors
        private Corvisquire()
            : base(
                822,
                "Corvisquire",
                "Bleuseille",
                TypeFlying.Instance,
                8,
                160,
                "Raven Pokémon",
                "Pokémon Corbeau",
                "The lessons of many harsh battles have taught it how to accurately judge an opponent’s strength.",
                "Après avoir surmonté tant de rudes combats, il a appris à déterminer avec précision la puissance de ses adversaires.",
                68,
                67,
                55,
                43,
                55,
                77
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
            this._moveList.Add(Fly.Instance);
            this._moveList.Add(FuryAttack.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(DrillPeck.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(Pluck.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(BraveBird.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(PowerTrip.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}