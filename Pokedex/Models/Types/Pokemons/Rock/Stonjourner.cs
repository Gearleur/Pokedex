// https://www.pokemon.com/us/pokedex/874

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Rock
{
    internal class Stonjourner : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Stonjourner()); }
        }
        #endregion
        
        #region Constructors
        private Stonjourner()
            : base(
                874,
                "Stonjourner",
                "Dolman",
                TypeRock.Instance,
                25,
                5200,
                "Big Rock Pokémon",
                "Pokémon Mégalithe",
                "Once a year, on a specific date and at a specific time, they gather out of nowhere and form up in a circle.",
                "Tous les ans à la même date, ils arrivent de nulle part pour se réunir en cercle. C’est une de leurs coutumes.",
                100,
                125,
                135,
                20,
                20,
                70
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
            this._moveList.Add(Stomp.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(RockThrow.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(SelfDestruct.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SandTomb.Instance);
            this._moveList.Add(RockBlast.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(StompingTantrum.Instance);
            this._moveList.Add(BodyPress.Instance);
            this._moveList.Add(MeteorBeam.Instance);
        }
        #endregion
    }
}