// https://www.pokemon.com/us/pokedex/892

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fighting
{
    internal class UrshifuSingleStrike : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new UrshifuSingleStrike()); }
        }
        #endregion
        
        #region Constructors
        private UrshifuSingleStrike()
            : base(
                892,
                "Urshifu",
                "Shifours",
                TypeFighting.Instance,
                TypeDark.Instance,
                19,
                1050,
                "Wushu Pokémon",
                "Pokémon Kung-fu",
                "Inhabiting the mountains of a distant region, this Pokémon races across sheer cliffs, training its legs and refining its moves.",
                "Il vit dans une lointaine région montagneuse où il peaufine ses techniques et muscle ses jambes en courant le long des falaises abruptes.",
                100,
                130,
                100,
                63,
                60,
                97
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
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(DynamicPunch.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(FocusPunch.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(CloseCombat.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(LowSweep.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(Snarl.Instance);
            this._moveList.Add(DarkestLariat.Instance);
            this._moveList.Add(ThroatChop.Instance);
            this._moveList.Add(BodyPress.Instance);
            this._moveList.Add(LashOut.Instance);
            this._moveList.Add(WickedBlow.Instance);
        }
        #endregion
    }
}