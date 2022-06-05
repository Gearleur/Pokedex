// https://www.pokemon.com/us/pokedex/119

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Seaking : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Seaking()); }
        }
        #endregion
        
        #region Constructors
        private Seaking()
            : base(
                119,
                "Seaking",
                "Poissoroy",
                TypeWater.Instance,
                13,
                390,
                "Goldfish Pokémon",
                "Pokémon Poisson",
                "Using its horn, it bores holes in riverbed boulders, making nests to prevent its eggs from washing away.",
                "S’il fait des trous dans les rochers avec sa corne pour bâtir son nid, c’est pour éviter que ses Œufs ne soient emportés par les flots.",
                80,
                92,
                65,
                65,
                80,
                68
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
            this._moveList.Add(HornAttack.Instance);
            this._moveList.Add(FuryAttack.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(Psybeam.Instance);
            this._moveList.Add(BubbleBeam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(Rage.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(SkullBash.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(Megahorn.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Whirlpool.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(MuddyWater.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(DrillRun.Instance);
            this._moveList.Add(ThroatChop.Instance);
            this._moveList.Add(ScaleShot.Instance);
            this._moveList.Add(FlipTurn.Instance);
        }
        #endregion
    }
}