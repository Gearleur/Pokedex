// https://www.pokemon.com/us/pokedex/182

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Bellossom : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Bellossom()); }
        }
        #endregion
        
        #region Constructors
        private Bellossom()
            : base(
                182,
                "Bellossom",
                "Joliflor",
                TypeGrass.Instance,
                4,
                58,
                "Flower Pokémon",
                "Pokémon Fleur",
                "Bellossom gather at times and appear to dance. They say that the dance is a ritual to summon the sun.",
                "Les Joliflor se réunissent parfois pour danser. On pense que c’est un rituel pour invoquer le soleil.",
                75,
                80,
                95,
                90,
                100,
                50
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
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Acid.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Absorb.Instance);
            this._moveList.Add(MegaDrain.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(PetalDance.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(LeafBlade.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(LeafStorm.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(PetalBlizzard.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(Moonblast.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(Infestation.Instance);
            this._moveList.Add(GrassyGlide.Instance);
        }
        #endregion
    }
}