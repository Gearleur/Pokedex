// https://www.pokemon.com/us/pokedex/792

using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Psy
{
    internal class Lunala : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Lunala()); }
        }
        #endregion
        
        #region Constructors
        private Lunala()
            : base(
                792,
                "Lunala",
                "Lunala",
                TypePsy.Instance,
                TypeGhost.Instance,
                40,
                1200,
                "Moone Pokémon",
                "Pokémon Halo Lunaire",
                "It steals the light from its surroundings and then becomes the full moon, showering its own light across the night sky.",
                "Il capture toute la lumière qui l’entoure pour prendre la forme de la pleine lune et éclairer les ténèbres nocturnes.",
                137,
                113,
                89,
                137,
                107,
                97
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
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Confusion.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(SkyAttack.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(FutureSight.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(PsychoCut.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Psyshock.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Hex.Instance);
            this._moveList.Add(SkyDrop.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(NightDaze.Instance);
            this._moveList.Add(PhantomForce.Instance);
            this._moveList.Add(Moonblast.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(MoongeistBeam.Instance);
            this._moveList.Add(ExpandingForce.Instance);
            this._moveList.Add(MeteorBeam.Instance);
            this._moveList.Add(Poltergeist.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}