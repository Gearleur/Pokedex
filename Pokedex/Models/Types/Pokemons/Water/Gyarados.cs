// https://www.pokemon.com/us/pokedex/130

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Gyarados : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Gyarados()); }
        }
        #endregion
        
        #region Constructors
        private Gyarados()
            : base(
                130,
                "Gyarados",
                "Léviator",
                TypeWater.Instance,
                TypeFlying.Instance,
                65,
                2350,
                "Atrocious Pokémon",
                "Pokémon Terrifiant",
                "Once it begins to rampage, a Gyarados will burn everything down, even in a harsh storm.",
                "Quand il se laisse emporter par la rage, même la plus violente des tempêtes ne peut l’empêcher de détruire tout ce qui l’entoure.",
                95,
                125,
                79,
                60,
                100,
                81
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
            this._moveList.Add(Bind.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(Thrash.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(BubbleBeam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Rage.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(SkullBash.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(ZapCannon.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(Outrage.Instance);
            this._moveList.Add(DragonBreath.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Twister.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Whirlpool.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(MuddyWater.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(Brine.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(Avalanche.Instance);
            this._moveList.Add(IceFang.Instance);
            this._moveList.Add(PowerWhip.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(DragonTail.Instance);
            this._moveList.Add(Hurricane.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(ScaleShot.Instance);
            this._moveList.Add(LashOut.Instance);
        }
        #endregion
    }
}