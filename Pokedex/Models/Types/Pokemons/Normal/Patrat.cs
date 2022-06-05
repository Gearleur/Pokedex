// https://www.pokemon.com/us/pokedex/504

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Patrat : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Patrat()); }
        }
        #endregion
        
        #region Constructors
        private Patrat()
            : base(
                504,
                "Patrat",
                "Ratentif",
                TypeNormal.Instance,
                5,
                116,
                "Scout Pokémon",
                "Pokémon Espion",
                "Extremely cautious, one of them will always be on the lookout, but it won’t notice a foe coming from behind.",
                "Ils stockent à manger dans leurs bajoues et font le guet indéfiniment. Ils se font des signes en remuant la queue.",
                45,
                55,
                39,
                35,
                39,
                42
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
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(Slam.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(HyperFang.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Pursuit.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(GunkShot.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Retaliate.Instance);
        }
        #endregion
    }
}