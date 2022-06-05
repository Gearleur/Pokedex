// https://www.pokemon.com/us/pokedex/102

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Exeggcute : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Exeggcute()); }
        }
        #endregion
        
        #region Constructors
        private Exeggcute()
            : base(
                102,
                "Exeggcute",
                "Noeunoeuf",
                TypeGrass.Instance,
                TypePsy.Instance,
                4,
                25,
                "Egg Pokémon",
                "Pokémon Œuf",
                "These Pokémon get nervous when they’re not in a group of six. The minute even one member of the group goes missing, Exeggcute become cowardly.",
                "Il a besoin d’être constitué de ses six membres pour rester calme. Sitôt qu’il en manque un, il lui prend soudainement l’envie de fuir.",
                60,
                40,
                80,
                60,
                45,
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
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Psybeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Absorb.Instance);
            this._moveList.Add(MegaDrain.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Confusion.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(Rage.Instance);
            this._moveList.Add(SelfDestruct.Instance);
            this._moveList.Add(EggBomb.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(Barrage.Instance);
            this._moveList.Add(Explosion.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Extrasensory.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(LeafStorm.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Infestation.Instance);
            this._moveList.Add(GrassyGlide.Instance);
        }
        #endregion
    }
}