// https://www.pokemon.com/us/pokedex/823

using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Flying
{
    internal class Corviknight : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Corviknight()); }
        }
        #endregion
        
        #region Constructors
        private Corviknight()
            : base(
                823,
                "Corviknight",
                "Corvaillus",
                TypeFlying.Instance,
                TypeSteel.Instance,
                22,
                750,
                "Raven Pokémon",
                "Pokémon Corbeau",
                "With their great intellect and flying skills, these Pokémon very successfully act as the Galar region’s airborne taxi service.",
                "Grâce à son adresse remarquable en vol et sa grande intelligence, il travaille comme taxi volant de Galar.",
                98,
                87,
                105,
                53,
                85,
                67
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
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(DrillPeck.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SteelWing.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(Pluck.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(BraveBird.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(Hurricane.Instance);
            this._moveList.Add(PowerTrip.Instance);
            this._moveList.Add(BodyPress.Instance);
            this._moveList.Add(SteelBeam.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}