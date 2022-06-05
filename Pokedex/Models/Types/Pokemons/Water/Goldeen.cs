// https://www.pokemon.com/us/pokedex/118

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
    internal class Goldeen : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Goldeen()); }
        }
        #endregion
        
        #region Constructors
        private Goldeen()
            : base(
                118,
                "Goldeen",
                "Poissirène",
                TypeWater.Instance,
                6,
                150,
                "Goldfish Pokémon",
                "Pokémon Poisson",
                "Its dorsal and pectoral fins are strongly developed like muscles. It can swim at a speed of five knots.",
                "Ses nageoires dorsales et pectorales sont très développées. Elles lui permettent de nager à une vitesse de cinq nœuds.",
                45,
                67,
                60,
                35,
                50,
                63
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