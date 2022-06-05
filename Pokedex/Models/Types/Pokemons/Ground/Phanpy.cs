// https://www.pokemon.com/us/pokedex/231

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ground
{
    internal class Phanpy : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Phanpy()); }
        }
        #endregion
        
        #region Constructors
        private Phanpy()
            : base(
                231,
                "Phanpy",
                "Phanpy",
                TypeGround.Instance,
                5,
                335,
                "Long Nose Pokémon",
                "Pokémon Long-Nez",
                "Phanpy uses its long nose to shower itself. When others gather around, they thoroughly douse each other with water. These Pokémon can be seen drying their soaking-wet bodies at the edge of water.",
                "Phanpy utilise sa petite trompe pour se doucher. Quand plusieurs d’entre eux se réunissent, ils s’arrosent joyeusement. On peut souvent voir ces Pokémon se sécher au bord de l’eau.",
                90,
                60,
                60,
                40,
                40,
                40
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
            this._moveList.Add(Slam.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(IceShard.Instance);
            this._moveList.Add(GunkShot.Instance);
            this._moveList.Add(HeadSmash.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(HighHorsepower.Instance);
        }
        #endregion
    }
}