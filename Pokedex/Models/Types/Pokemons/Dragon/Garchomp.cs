// https://www.pokemon.com/us/pokedex/445

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Dragon
{
    internal class Garchomp : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Garchomp()); }
        }
        #endregion
        
        #region Constructors
        private Garchomp()
            : base(
                445,
                "Garchomp",
                "Carchacrok",
                TypeDragon.Instance,
                TypeGround.Instance,
                19,
                950,
                "Mach Pokémon",
                "Pokémon Supersonic",
                "Garchomp is fast both underground and above. It can bring down prey and return to its den before its body has chilled from being outside.",
                "Ce Pokémon très rapide même au sol capture ses proies sur les monts enneigés et rentre vite dans son antre avant que son corps ne gèle.",
                108,
                130,
                95,
                80,
                85,
                102
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
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(Outrage.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(DragonBreath.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Twister.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Whirlpool.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SandTomb.Instance);
            this._moveList.Add(DragonClaw.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(DragonRush.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(FireFang.Instance);
            this._moveList.Add(RockClimb.Instance);
            this._moveList.Add(DracoMeteor.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(DragonTail.Instance);
            this._moveList.Add(DualChop.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(StompingTantrum.Instance);
            this._moveList.Add(BreakingSwipe.Instance);
            this._moveList.Add(ScaleShot.Instance);
            this._moveList.Add(ScorchingSands.Instance);
        }
        #endregion
    }
}