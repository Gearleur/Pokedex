// https://www.pokemon.com/us/pokedex/589

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Escavalier : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Escavalier()); }
        }
        #endregion
        
        #region Constructors
        private Escavalier()
            : base(
                589,
                "Escavalier",
                "Lançargot",
                TypeBug.Instance,
                TypeSteel.Instance,
                10,
                330,
                "Cavalry Pokémon",
                "Pokémon Chevalier",
                "It charges its enemies, lances at the ready. An image of one of its duels is captured in a famous painting of Escavalier clashing with Sirfetch’d.",
                "Il charge ses ennemis en brandissant ses lances. Il existe un célèbre tableau représentant la joute entre un Lançargot et un Palarticho.",
                70,
                135,
                105,
                60,
                105,
                20
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
            this._moveList.Add(FuryAttack.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Twineedle.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(Megahorn.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(CloseCombat.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(BugBuzz.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(AcidSpray.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(StruggleBug.Instance);
            this._moveList.Add(DrillRun.Instance);
            this._moveList.Add(RazorShell.Instance);
            this._moveList.Add(FellStinger.Instance);
            this._moveList.Add(Infestation.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(SteelBeam.Instance);
        }
        #endregion
    }
}