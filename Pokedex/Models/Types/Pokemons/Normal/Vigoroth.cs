// https://www.pokemon.com/us/pokedex/288

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Vigoroth : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Vigoroth()); }
        }
        #endregion
        
        #region Constructors
        private Vigoroth()
            : base(
                288,
                "Vigoroth",
                "Vigoroth",
                TypeNormal.Instance,
                14,
                465,
                "Wild Monkey Pokémon",
                "Pokémon Turbusinge",
                "Vigoroth is simply incapable of remaining still. Even when it tries to sleep, the blood in its veins grows agitated, compelling this Pokémon to run wild throughout the jungle before it can settle down.",
                "Vigoroth ne tient pas en place. Même quand il essaie de dormir, le sang dans ses veines s’agite, obligeant ce Pokémon à courir comme un fou dans la forêt pour s’épuiser afin de pouvoir se reposer.",
                80,
                80,
                80,
                55,
                55,
                90
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
            this._moveList.Add(FirePunch.Instance);
            this._moveList.Add(IcePunch.Instance);
            this._moveList.Add(ThunderPunch.Instance);
            this._moveList.Add(Scratch.Instance);
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(FurySwipes.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(DynamicPunch.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(FocusPunch.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(RockClimb.Instance);
            this._moveList.Add(GunkShot.Instance);
            this._moveList.Add(LowSweep.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(ChipAway.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
        }
        #endregion
    }
}