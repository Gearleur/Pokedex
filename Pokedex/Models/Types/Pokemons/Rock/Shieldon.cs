// https://www.pokemon.com/us/pokedex/410

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Rock
{
    internal class Shieldon : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Shieldon()); }
        }
        #endregion
        
        #region Constructors
        private Shieldon()
            : base(
                410,
                "Shieldon",
                "Dinoclier",
                TypeRock.Instance,
                TypeSteel.Instance,
                5,
                570,
                "Shield Pokémon",
                "Pokémon Bouclier",
                "Although its fossils can be found in layers of primeval rock, nothing but its face has ever been discovered.",
                "On retrouve des fossiles de Dinoclier dans les couches sédimentaires préhistoriques, mais seule sa tête a résisté à l’épreuve du temps.",
                30,
                42,
                118,
                42,
                88,
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
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(RockBlast.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(SmackDown.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(Bulldoze.Instance);
        }
        #endregion
    }
}