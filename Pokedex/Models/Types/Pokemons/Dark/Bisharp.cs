// https://www.pokemon.com/us/pokedex/625

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Dark
{
    internal class Bisharp : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Bisharp()); }
        }
        #endregion
        
        #region Constructors
        private Bisharp()
            : base(
                625,
                "Bisharp",
                "Scalproie",
                TypeDark.Instance,
                TypeSteel.Instance,
                16,
                700,
                "Sword Blade Pokémon",
                "Pokémon Tranchant",
                "Violent conflicts erupt between Bisharp and Fraxure over places where sharpening stones can be found.",
                "Sa recherche des meilleurs endroits où trouver des pierres pour affûter ses lames le conduit souvent à affronter des Incisache.",
                65,
                125,
                100,
                60,
                70,
                70
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
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(MetalClaw.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(NightSlash.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(PsychoCut.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(LowSweep.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(DualChop.Instance);
            this._moveList.Add(Snarl.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
            this._moveList.Add(ThroatChop.Instance);
            this._moveList.Add(SteelBeam.Instance);
            this._moveList.Add(LashOut.Instance);
        }
        #endregion
    }
}