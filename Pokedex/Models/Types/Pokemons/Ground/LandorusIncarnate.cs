// https://www.pokemon.com/us/pokedex/645

using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ground
{
    internal class LandorusIncarnate : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new LandorusIncarnate()); }
        }
        #endregion
        
        #region Constructors
        private LandorusIncarnate()
            : base(
                645,
                "Landorus",
                "Démétéros",
                TypeGround.Instance,
                TypeFlying.Instance,
                15,
                680,
                "Abundance Pokémon",
                "Pokémon Fertilité",
                "From the forces of lightning and wind, it creates energy to give nutrients to the soil and make the land abundant.",
                "Il utilise l’énergie qu’il tire du vent et de la foudre pour enrichir les sols en nutriments pour les cultures.",
                89,
                125,
                90,
                115,
                80,
                101
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
            this._moveList.Add(Fly.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(RockThrow.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(SelfDestruct.Instance);
            this._moveList.Add(Explosion.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(Outrage.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(Extrasensory.Instance);
            this._moveList.Add(SandTomb.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(HammerArm.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(SmackDown.Instance);
            this._moveList.Add(SludgeWave.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(BrutalSwing.Instance);
        }
        #endregion
    }
}