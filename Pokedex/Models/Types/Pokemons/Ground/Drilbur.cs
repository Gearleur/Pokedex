// https://www.pokemon.com/us/pokedex/529

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ground
{
    internal class Drilbur : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Drilbur()); }
        }
        #endregion
        
        #region Constructors
        private Drilbur()
            : base(
                529,
                "Drilbur",
                "Rototaupe",
                TypeGround.Instance,
                3,
                85,
                "Mole Pokémon",
                "Pokémon Taupe",
                "It’s a digger, using its claws to burrow through the ground. It causes damage to vegetable crops, so many farmers have little love for it.",
                "Les cultivateurs le détestent, car il abîme leurs légumes en creusant la terre avec ses griffes.",
                60,
                85,
                40,
                30,
                45,
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
            this._moveList.Add(Scratch.Instance);
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(Submission.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(SkullBash.Instance);
            this._moveList.Add(FurySwipes.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(RapidSpin.Instance);
            this._moveList.Add(MetalClaw.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(CrushClaw.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SandTomb.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(RockClimb.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(DrillRun.Instance);
            this._moveList.Add(HighHorsepower.Instance);
            this._moveList.Add(ScorchingSands.Instance);
        }
        #endregion
    }
}