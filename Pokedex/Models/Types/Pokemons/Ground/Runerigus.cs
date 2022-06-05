// https://www.pokemon.com/us/pokedex/867

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ground
{
    internal class Runerigus : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Runerigus()); }
        }
        #endregion
        
        #region Constructors
        private Runerigus()
            : base(
                867,
                "Runerigus",
                "Tutétékri",
                TypeGround.Instance,
                TypeGhost.Instance,
                16,
                666,
                "Grudge Pokémon",
                "Pokémon Rancune",
                "Never touch its shadowlike body, or you’ll be shown the horrific memories behind the picture carved into it.",
                "Quiconque touchera son corps semblable à une ombre devra endurer la vision des souvenirs effroyables gravés dans ses motifs.",
                58,
                95,
                145,
                50,
                105,
                30
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
            this._moveList.Add(Slam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SandTomb.Instance);
            this._moveList.Add(RockBlast.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Hex.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(PhantomForce.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(BodyPress.Instance);
            this._moveList.Add(Poltergeist.Instance);
        }
        #endregion
    }
}