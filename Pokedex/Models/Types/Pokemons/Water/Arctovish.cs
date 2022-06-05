// https://www.pokemon.com/us/pokedex/883

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Arctovish : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Arctovish()); }
        }
        #endregion
        
        #region Constructors
        private Arctovish()
            : base(
                883,
                "Arctovish",
                "Hydragla",
                TypeWater.Instance,
                TypeIce.Instance,
                20,
                1750,
                "Fossil Pokémon",
                "Pokémon Fossile",
                "The skin on its face is impervious to attack, but breathing difficulties made this Pokémon go extinct anyway.",
                "Aucune attaque ne pouvait égratigner la peau de son visage, mais il s’est éteint, car il avait du mal à respirer.",
                90,
                90,
                100,
                80,
                90,
                55
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
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(PowderSnow.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(Whirlpool.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(IcicleSpear.Instance);
            this._moveList.Add(RockBlast.Instance);
            this._moveList.Add(Brine.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(Avalanche.Instance);
            this._moveList.Add(IceFang.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(IcicleCrash.Instance);
            this._moveList.Add(FreezeDry.Instance);
            this._moveList.Add(PsychicFangs.Instance);
            this._moveList.Add(Liquidation.Instance);
            this._moveList.Add(FishiousRend.Instance);
            this._moveList.Add(MeteorBeam.Instance);
        }
        #endregion
    }
}