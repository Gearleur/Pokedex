// https://www.pokemon.com/us/pokedex/898

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Psy
{
    internal class Calyrex : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Calyrex()); }
        }
        #endregion
        
        #region Constructors
        private Calyrex()
            : base(
                898,
                "Calyrex",
                "Sylveroy",
                TypePsy.Instance,
                TypeGrass.Instance,
                11,
                77,
                "King Pokémon",
                "Pokémon Roi",
                "Calyrex is known in legend as a king that ruled over Galar in ancient times. It has the power to cause hearts to mend and plants to spring forth.",
                "Ce roi légendaire qui a régné sur Galar il y a fort longtemps possède le pouvoir d’apaiser les cœurs et de faire germer les plantes.",
                100,
                80,
                80,
                80,
                80,
                80
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
            this._moveList.Add(Pound.Instance);
            this._moveList.Add(PayDay.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(MegaDrain.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Confusion.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(TriAttack.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(FutureSight.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(LeafStorm.Instance);
            this._moveList.Add(Psyshock.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(DrainingKiss.Instance);
            this._moveList.Add(SolarBlade.Instance);
            this._moveList.Add(PollenPuff.Instance);
            this._moveList.Add(ExpandingForce.Instance);
        }
        #endregion
    }
}