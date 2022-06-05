// https://www.pokemon.com/us/pokedex/465

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Tangrowth : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Tangrowth()); }
        }
        #endregion
        
        #region Constructors
        private Tangrowth()
            : base(
                465,
                "Tangrowth",
                "Bouldeneu",
                TypeGrass.Instance,
                20,
                1286,
                "Vine Pokémon",
                "Pokémon Vigne",
                "Vine growth is accelerated for Tangrowth living in warm climates. If the vines grow long, Tangrowth shortens them by tearing parts of them off.",
                "Ses lianes poussent plus rapidement s’il vit sous un climat chaud. Quand elles deviennent trop longues, il se les coupe.",
                100,
                100,
                125,
                110,
                50,
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
            this._moveList.Add(Bind.Instance);
            this._moveList.Add(Slam.Instance);
            this._moveList.Add(VineWhip.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Absorb.Instance);
            this._moveList.Add(MegaDrain.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Constrict.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(LeafStorm.Instance);
            this._moveList.Add(PowerWhip.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(Infestation.Instance);
            this._moveList.Add(SolarBlade.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(StompingTantrum.Instance);
            this._moveList.Add(GrassyGlide.Instance);
        }
        #endregion
    }
}