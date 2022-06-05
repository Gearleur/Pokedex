// https://www.pokemon.com/us/pokedex/837

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Rock
{
    internal class Rolycoly : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Rolycoly()); }
        }
        #endregion
        
        #region Constructors
        private Rolycoly()
            : base(
                837,
                "Rolycoly",
                "Charbi",
                TypeRock.Instance,
                3,
                120,
                "Coal Pokémon",
                "Pokémon Charbon",
                "It can race around like a unicycle, even on rough, rocky terrain. Burning coal sustains it.",
                "Il parcourt sans difficulté les sentiers rocheux accidentés à la manière d’un monocycle. Il a besoin de brûler du charbon pour vivre.",
                30,
                40,
                50,
                40,
                50,
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
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(SelfDestruct.Instance);
            this._moveList.Add(Explosion.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(RapidSpin.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SandTomb.Instance);
            this._moveList.Add(RockBlast.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(SmackDown.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(MeteorBeam.Instance);
        }
        #endregion
    }
}