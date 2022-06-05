// https://www.pokemon.com/us/pokedex/821

using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Flying
{
    internal class Rookidee : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Rookidee()); }
        }
        #endregion
        
        #region Constructors
        private Rookidee()
            : base(
                821,
                "Rookidee",
                "Minisange",
                TypeFlying.Instance,
                2,
                18,
                "Tiny Bird Pokémon",
                "Pokémon Minoiseau",
                "Jumping nimbly about, this small-bodied Pokémon takes advantage of even the slightest opportunity to disorient larger opponents.",
                "Son petit corps lui permet de se jouer d’ennemis bien plus grands que lui en volant à toute vitesse pour les piquer où ils sont vulnérables.",
                38,
                47,
                35,
                33,
                35,
                57
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
            this._moveList.Add(SkyAttack.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(RockSmash.Instance);
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