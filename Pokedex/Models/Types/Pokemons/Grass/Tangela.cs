// https://www.pokemon.com/us/pokedex/114

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Tangela : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Tangela()); }
        }
        #endregion
        
        #region Constructors
        private Tangela()
            : base(
                114,
                "Tangela",
                "Saquedeneu",
                TypeGrass.Instance,
                10,
                350,
                "Vine Pokémon",
                "Pokémon Vigne",
                "The vines of a Tangela have a distinct scent. In some parts of Galar, Tangela vines are used as herbs.",
                "Ses lianes ont une odeur particulière. Elles servent d’herbes aromatiques dans une certaine zone de Galar.",
                65,
                55,
                115,
                100,
                40,
                60
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
            this._moveList.Add(Bind.Instance);
            this._moveList.Add(Slam.Instance);
            this._moveList.Add(VineWhip.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Absorb.Instance);
            this._moveList.Add(MegaDrain.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Confusion.Instance);
            this._moveList.Add(Rage.Instance);
            this._moveList.Add(SkullBash.Instance);
            this._moveList.Add(Constrict.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(WakeUpSlap.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(LeafStorm.Instance);
            this._moveList.Add(PowerWhip.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Infestation.Instance);
            this._moveList.Add(GrassyGlide.Instance);
        }
        #endregion
    }
}