// https://www.pokemon.com/us/pokedex/847

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Barraskewda : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Barraskewda()); }
        }
        #endregion
        
        #region Constructors
        private Barraskewda()
            : base(
                847,
                "Barraskewda",
                "Hastacuda",
                TypeWater.Instance,
                13,
                300,
                "Skewer Pokémon",
                "Pokémon Transperceur",
                "It spins its tail fins to propel itself, surging forward at speeds of over 100 knots before ramming prey and spearing into them.",
                "Il charge d’un coup en faisant tourner sa nageoire caudale. Il peut transpercer ses proies à une vitesse dépassant les 100 nœuds.",
                61,
                123,
                60,
                60,
                50,
                136
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
            this._moveList.Add(FuryAttack.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(Whirlpool.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(CloseCombat.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(IceFang.Instance);
            this._moveList.Add(AquaJet.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(DrillRun.Instance);
            this._moveList.Add(ThroatChop.Instance);
            this._moveList.Add(PsychicFangs.Instance);
            this._moveList.Add(Liquidation.Instance);
            this._moveList.Add(ScaleShot.Instance);
            this._moveList.Add(FlipTurn.Instance);
        }
        #endregion
    }
}