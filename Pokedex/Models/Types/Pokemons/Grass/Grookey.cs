// https://www.pokemon.com/us/pokedex/810

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Grookey : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Grookey()); }
        }
        #endregion
        
        #region Constructors
        private Grookey()
            : base(
                810,
                "Grookey",
                "Ouistempo",
                TypeGrass.Instance,
                3,
                50,
                "Chimp Pokémon",
                "Pokémon Chimpanzé",
                "It attacks with rapid beats of its stick. As it strikes with amazing speed, it gets more and more pumped.",
                "Il attaque en frappant frénétiquement avec son bâton. Son enthousiasme grandit à mesure que le rythme s’accélère.",
                50,
                65,
                50,
                40,
                40,
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
            this._moveList.Add(Scratch.Instance);
            this._moveList.Add(Slam.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(RazorLeaf.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(FakeOut.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(HammerArm.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(WoodHammer.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(GrassPledge.Instance);
            this._moveList.Add(SolarBlade.Instance);
            this._moveList.Add(BranchPoke.Instance);
            this._moveList.Add(GrassyGlide.Instance);
        }
        #endregion
    }
}