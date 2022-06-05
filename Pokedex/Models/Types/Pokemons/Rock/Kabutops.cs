// https://www.pokemon.com/us/pokedex/141

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Rock
{
    internal class Kabutops : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Kabutops()); }
        }
        #endregion
        
        #region Constructors
        private Kabutops()
            : base(
                141,
                "Kabutops",
                "Kabutops",
                TypeRock.Instance,
                TypeWater.Instance,
                13,
                405,
                "Shellfish Pokémon",
                "Pokémon Carapace",
                "The cause behind the extinction of this species is unknown. Kabutops were aggressive Pokémon that inhabited warm seas.",
                "Nul ne sait pourquoi il s’est éteint. Ce Pokémon préhistorique féroce vivait dans les mers chaudes.",
                60,
                115,
                105,
                65,
                70,
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
            this._moveList.Add(Scratch.Instance);
            this._moveList.Add(RazorWind.Instance);
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(BubbleBeam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Submission.Instance);
            this._moveList.Add(Absorb.Instance);
            this._moveList.Add(MegaDrain.Instance);
            this._moveList.Add(RockThrow.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Rage.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(SkullBash.Instance);
            this._moveList.Add(LeechLife.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Whirlpool.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(RockBlast.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(Brine.Instance);
            this._moveList.Add(Feint.Instance);
            this._moveList.Add(NightSlash.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(PsychoCut.Instance);
            this._moveList.Add(RockClimb.Instance);
            this._moveList.Add(CrossPoison.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(AquaJet.Instance);
            this._moveList.Add(SmackDown.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(RazorShell.Instance);
            this._moveList.Add(Liquidation.Instance);
            this._moveList.Add(MeteorBeam.Instance);
            this._moveList.Add(FlipTurn.Instance);
        }
        #endregion
    }
}