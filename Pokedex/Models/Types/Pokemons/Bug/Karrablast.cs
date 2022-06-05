// https://www.pokemon.com/us/pokedex/588

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Karrablast : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Karrablast()); }
        }
        #endregion
        
        #region Constructors
        private Karrablast()
            : base(
                588,
                "Karrablast",
                "Carabing",
                TypeBug.Instance,
                5,
                59,
                "Clamping Pokémon",
                "Pokémon Carabe",
                "It spits a liquid from its mouth to melt through Shelmet’s shell. Karrablast doesn’t eat the shell— it eats only the contents.",
                "Il crache un liquide qui dissout les coquilles des Escargaume pour se régaler de leur contenu.",
                50,
                75,
                45,
                40,
                45,
                60
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
            this._moveList.Add(HornAttack.Instance);
            this._moveList.Add(FuryAttack.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(Megahorn.Instance);
            this._moveList.Add(Pursuit.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(NightSlash.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(BugBuzz.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(AcidSpray.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(StruggleBug.Instance);
            this._moveList.Add(DrillRun.Instance);
            this._moveList.Add(Infestation.Instance);
        }
        #endregion
    }
}