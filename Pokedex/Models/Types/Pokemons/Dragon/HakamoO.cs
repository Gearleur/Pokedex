// https://www.pokemon.com/us/pokedex/783

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Dragon
{
    internal class HakamoO : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new HakamoO()); }
        }
        #endregion
        
        #region Constructors
        private HakamoO()
            : base(
                783,
                "Hakamo-o",
                "Écaïd",
                TypeDragon.Instance,
                TypeFighting.Instance,
                12,
                470,
                "Scaly Pokémon",
                "Pokémon Écailles",
                "Before attacking its enemies, it clashes its scales together and roars. Its sharp claws shred the opposition.",
                "Après avoir fait tinter ses écailles et poussé un terrible cri de guerre, il charge ses ennemis et les lacère de ses griffes acérées.",
                55,
                75,
                90,
                65,
                70,
                65
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
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Outrage.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SkyUppercut.Instance);
            this._moveList.Add(DragonClaw.Instance);
            this._moveList.Add(CloseCombat.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(DracoMeteor.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(DragonTail.Instance);
            this._moveList.Add(DualChop.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(ScaleShot.Instance);
        }
        #endregion
    }
}