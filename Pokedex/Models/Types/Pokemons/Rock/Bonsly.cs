// https://www.pokemon.com/us/pokedex/438

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Rock
{
    internal class Bonsly : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Bonsly()); }
        }
        #endregion
        
        #region Constructors
        private Bonsly()
            : base(
                438,
                "Bonsly",
                "Manzaï",
                TypeRock.Instance,
                5,
                150,
                "Bonsai Pokémon",
                "Pokémon Bonsaï",
                "This Pokémon lives in dry, rocky areas. As its green spheres dry out, their dull luster increases.",
                "Il vit dans les zones rocheuses arides. Quand ses boules vertes sont sèches, elles se mettent à briller légèrement.",
                50,
                80,
                95,
                10,
                45,
                10
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
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(RockThrow.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(SelfDestruct.Instance);
            this._moveList.Add(Explosion.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SandTomb.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(SmackDown.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(StompingTantrum.Instance);
        }
        #endregion
    }
}