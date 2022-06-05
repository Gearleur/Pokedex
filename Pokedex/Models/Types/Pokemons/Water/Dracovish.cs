// https://www.pokemon.com/us/pokedex/882

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Dracovish : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Dracovish()); }
        }
        #endregion
        
        #region Constructors
        private Dracovish()
            : base(
                882,
                "Dracovish",
                "Hydragon",
                TypeWater.Instance,
                TypeDragon.Instance,
                23,
                2150,
                "Fossil Pokémon",
                "Pokémon Fossile",
                "Its mighty legs are capable of running at speeds exceeding 40 mph, but this Pokémon can’t breathe unless it’s underwater.",
                "Ses pattes robustes lui permettent de courir à plus de 60 km/h, mais en revanche, il ne peut respirer que sous l’eau.",
                90,
                90,
                100,
                70,
                80,
                75
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
            this._moveList.Add(Stomp.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(LeechLife.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Outrage.Instance);
            this._moveList.Add(DragonBreath.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(Whirlpool.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(RockBlast.Instance);
            this._moveList.Add(Brine.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(DragonRush.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(IceFang.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(DracoMeteor.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(PsychicFangs.Instance);
            this._moveList.Add(StompingTantrum.Instance);
            this._moveList.Add(Liquidation.Instance);
            this._moveList.Add(FishiousRend.Instance);
            this._moveList.Add(MeteorBeam.Instance);
        }
        #endregion
    }
}