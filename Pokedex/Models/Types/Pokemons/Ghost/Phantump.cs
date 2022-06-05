// https://www.pokemon.com/us/pokedex/708

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ghost
{
    internal class Phantump : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Phantump()); }
        }
        #endregion
        
        #region Constructors
        private Phantump()
            : base(
                708,
                "Phantump",
                "Brocélôme",
                TypeGhost.Instance,
                TypeGrass.Instance,
                4,
                70,
                "Stump Pokémon",
                "Pokémon Souche",
                "With a voice like a human child’s, it cries out to lure adults deep into the forest, getting them lost among the trees.",
                "Il imite des cris d’enfants pour pousser les adultes à venir se perdre au plus profond de la forêt.",
                43,
                70,
                48,
                50,
                60,
                38
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
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(WoodHammer.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Hex.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(HornLeech.Instance);
            this._moveList.Add(PhantomForce.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
            this._moveList.Add(BranchPoke.Instance);
            this._moveList.Add(GrassyGlide.Instance);
            this._moveList.Add(SkitterSmack.Instance);
            this._moveList.Add(Poltergeist.Instance);
        }
        #endregion
    }
}