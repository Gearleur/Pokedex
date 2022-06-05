// https://www.pokemon.com/us/pokedex/704

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Dragon
{
    internal class Goomy : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Goomy()); }
        }
        #endregion
        
        #region Constructors
        private Goomy()
            : base(
                704,
                "Goomy",
                "Mucuscule",
                TypeDragon.Instance,
                3,
                28,
                "Soft Tissue Pokémon",
                "Pokémon Mollusque",
                "Their horns are powerful sensors. As soon as Goomy pick up any sign of enemies, they go into hiding. This is how they’ve survived.",
                "Ses cornes sont des organes sensoriels qui lui permettent de se cacher quand il détecte des ennemis. C’est grâce à cela qu’il vit toujours.",
                45,
                50,
                35,
                55,
                75,
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
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(Absorb.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Bubble.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(Outrage.Instance);
            this._moveList.Add(DragonBreath.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(MuddyWater.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(PoisonTail.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(DracoMeteor.Instance);
            this._moveList.Add(SludgeWave.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Infestation.Instance);
            this._moveList.Add(SkitterSmack.Instance);
        }
        #endregion
    }
}