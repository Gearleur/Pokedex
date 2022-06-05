// https://www.pokemon.com/us/pokedex/545

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Scolipede : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Scolipede()); }
        }
        #endregion
        
        #region Constructors
        private Scolipede()
            : base(
                545,
                "Scolipede",
                "Brutapode",
                TypeBug.Instance,
                TypePoison.Instance,
                25,
                2005,
                "Megapede Pokémon",
                "Pokémon Mégaplopode",
                "Scolipede engage in fierce territorial battles with Centiskorch. At the end of one of these battles, the victor makes a meal of the loser.",
                "Il défend son territoire avec acharnement contre son ennemi Scolocendre. Le perdant sert de dîner au vainqueur.",
                60,
                100,
                89,
                55,
                69,
                112
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
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(PoisonSting.Instance);
            this._moveList.Add(PinMissile.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(Megahorn.Instance);
            this._moveList.Add(Pursuit.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(PoisonTail.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(RockClimb.Instance);
            this._moveList.Add(CrossPoison.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Hex.Instance);
            this._moveList.Add(StruggleBug.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(Steamroller.Instance);
            this._moveList.Add(Infestation.Instance);
            this._moveList.Add(ThroatChop.Instance);
            this._moveList.Add(StompingTantrum.Instance);
            this._moveList.Add(SteelRoller.Instance);
            this._moveList.Add(SkitterSmack.Instance);
        }
        #endregion
    }
}