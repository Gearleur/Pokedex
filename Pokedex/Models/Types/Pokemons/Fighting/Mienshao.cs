// https://www.pokemon.com/us/pokedex/620

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fighting
{
    internal class Mienshao : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Mienshao()); }
        }
        #endregion
        
        #region Constructors
        private Mienshao()
            : base(
                620,
                "Mienshao",
                "Shaofouine",
                TypeFighting.Instance,
                14,
                355,
                "Martial Arts Pokémon",
                "Pokémon Art Martial",
                "Delivered at blinding speeds, kicks from this Pokémon can shatter massive boulders into tiny pieces.",
                "Ses coups de pied ultrarapides et invisibles à l’œil nu peuvent réduire un énorme rocher en poussière.",
                65,
                125,
                60,
                95,
                60,
                105
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
            this._moveList.Add(Pound.Instance);
            this._moveList.Add(DoubleSlap.Instance);
            this._moveList.Add(MegaPunch.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(JumpKick.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(HighJumpKick.Instance);
            this._moveList.Add(FurySwipes.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(FakeOut.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(FocusPunch.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(BlazeKick.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(CloseCombat.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(ForcePalm.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(LowSweep.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(DualChop.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
            this._moveList.Add(BrutalSwing.Instance);
        }
        #endregion
    }
}