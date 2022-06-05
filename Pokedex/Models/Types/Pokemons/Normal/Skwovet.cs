// https://www.pokemon.com/us/pokedex/819

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Skwovet : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Skwovet()); }
        }
        #endregion
        
        #region Constructors
        private Skwovet()
            : base(
                819,
                "Skwovet",
                "Rongourmand",
                TypeNormal.Instance,
                3,
                25,
                "Cheeky Pokémon",
                "Pokémon Joufflu",
                "It eats berries nonstop—a habit that has made it more resilient than it looks. It’ll show up on farms, searching for yet more berries.",
                "Comme il mange tout le temps des Baies, il est plus costaud qu’il n’en a l’air. Il parcourt les champs à la recherche de sa précieuse denrée.",
                70,
                55,
                55,
                35,
                35,
                25
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
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(TailSlap.Instance);
            this._moveList.Add(Belch.Instance);
            this._moveList.Add(BrutalSwing.Instance);
        }
        #endregion
    }
}