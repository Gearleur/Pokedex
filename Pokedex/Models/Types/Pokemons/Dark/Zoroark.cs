// https://www.pokemon.com/us/pokedex/571

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Dark
{
    internal class Zoroark : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Zoroark()); }
        }
        #endregion
        
        #region Constructors
        private Zoroark()
            : base(
                571,
                "Zoroark",
                "Zoroark",
                TypeDark.Instance,
                16,
                811,
                "Illusion Fox Pokémon",
                "Pokémon Polymorfox",
                "Seeking to ease the burden of their solitude, lonely Trainers tell Zoroark to show illusions to them.",
                "Les Dresseurs en manque de compagnie ordonnent à Zoroark de leur montrer une illusion pour tromper leur solitude.",
                60,
                105,
                60,
                120,
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
            this._moveList.Add(MegaPunch.Instance);
            this._moveList.Add(Scratch.Instance);
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(FurySwipes.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(Pursuit.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(NightSlash.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(LowSweep.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Hex.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(NightDaze.Instance);
            this._moveList.Add(Snarl.Instance);
            this._moveList.Add(ThroatChop.Instance);
            this._moveList.Add(SkitterSmack.Instance);
            this._moveList.Add(BurningJealousy.Instance);
            this._moveList.Add(LashOut.Instance);
        }
        #endregion
    }
}