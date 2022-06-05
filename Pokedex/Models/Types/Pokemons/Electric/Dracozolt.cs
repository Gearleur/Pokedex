// https://www.pokemon.com/us/pokedex/880

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Electric
{
    internal class Dracozolt : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Dracozolt()); }
        }
        #endregion
        
        #region Constructors
        private Dracozolt()
            : base(
                880,
                "Dracozolt",
                "Galvagon",
                TypeElectric.Instance,
                TypeDragon.Instance,
                18,
                1900,
                "Fossil Pokémon",
                "Pokémon Fossile",
                "The powerful muscles in its tail generate its electricity. Compared to its lower body, its upper half is entirely too small.",
                "Il envoie des décharges avec les muscles puissants de sa queue. La partie supérieure de son corps est trop petite par rapport à la partie inférieure.",
                90,
                100,
                90,
                80,
                70,
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
            this._moveList.Add(MegaPunch.Instance);
            this._moveList.Add(ThunderPunch.Instance);
            this._moveList.Add(Slam.Instance);
            this._moveList.Add(Stomp.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(FireSpin.Instance);
            this._moveList.Add(ThunderShock.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Outrage.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(DragonClaw.Instance);
            this._moveList.Add(RockBlast.Instance);
            this._moveList.Add(Pluck.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(DragonRush.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ThunderFang.Instance);
            this._moveList.Add(FireFang.Instance);
            this._moveList.Add(DracoMeteor.Instance);
            this._moveList.Add(Discharge.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(DragonTail.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(HighHorsepower.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(StompingTantrum.Instance);
            this._moveList.Add(BoltBeak.Instance);
            this._moveList.Add(BreakingSwipe.Instance);
            this._moveList.Add(MeteorBeam.Instance);
            this._moveList.Add(RisingVoltage.Instance);
        }
        #endregion
    }
}