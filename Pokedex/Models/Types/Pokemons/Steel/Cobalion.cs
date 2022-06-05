// https://www.pokemon.com/us/pokedex/638

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Steel
{
    internal class Cobalion : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Cobalion()); }
        }
        #endregion
        
        #region Constructors
        private Cobalion()
            : base(
                638,
                "Cobalion",
                "Cobaltium",
                TypeSteel.Instance,
                TypeFighting.Instance,
                21,
                2500,
                "Iron Will Pokémon",
                "Pokémon Cœur de Fer",
                "From the moment it’s born, this Pokémon radiates the air of a leader. Its presence will calm even vicious foes.",
                "Dès la naissance, il a un air de chef. Même le plus terrible des adversaires file doux face à lui.",
                91,
                90,
                129,
                90,
                72,
                108
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
            this._moveList.Add(DoubleKick.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(Megahorn.Instance);
            this._moveList.Add(MetalClaw.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(CloseCombat.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(VoltSwitch.Instance);
            this._moveList.Add(SacredSword.Instance);
            this._moveList.Add(SteelBeam.Instance);
        }
        #endregion
    }
}