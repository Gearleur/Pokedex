// https://www.pokemon.com/us/pokedex/739

using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fighting
{
    internal class Crabrawler : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Crabrawler()); }
        }
        #endregion
        
        #region Constructors
        private Crabrawler()
            : base(
                739,
                "Crabrawler",
                "Crabagarre",
                TypeFighting.Instance,
                6,
                70,
                "Boxing Pokémon",
                "Pokémon Boxeur",
                "Crabrawler has been known to mistake Exeggutor for a coconut tree and climb it. The enraged Exeggutor shakes it off and stomps it.",
                "Il grimpe parfois sur un Noadkoko qu’il a pris pour un cocotier. Il se fait alors éjecter puis piétiner par le Noadkoko courroucé.",
                47,
                82,
                57,
                42,
                47,
                63
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
            this._moveList.Add(IcePunch.Instance);
            this._moveList.Add(ThunderPunch.Instance);
            this._moveList.Add(BubbleBeam.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Bubble.Instance);
            this._moveList.Add(DizzyPunch.Instance);
            this._moveList.Add(Crabhammer.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(DynamicPunch.Instance);
            this._moveList.Add(Pursuit.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(FocusPunch.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(CloseCombat.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(FrostBreath.Instance);
            this._moveList.Add(DualChop.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
            this._moveList.Add(BrutalSwing.Instance);
        }
        #endregion
    }
}