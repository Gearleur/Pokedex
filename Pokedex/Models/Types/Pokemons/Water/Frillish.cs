// https://www.pokemon.com/us/pokedex/592

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Frillish : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Frillish()); }
        }
        #endregion
        
        #region Constructors
        private Frillish()
            : base(
                592,
                "Frillish",
                "Viskuse",
                TypeWater.Instance,
                TypeGhost.Instance,
                12,
                330,
                "Floating Pokémon",
                "Pokémon Flottaison",
                "Legend has it that the residents of a sunken ancient city changed into these Pokémon.",
                "Certaines légendes racontent que les Viskuse sont les habitants d’une ancienne cité engloutie qui ont été changés en Pokémon.",
                55,
                40,
                50,
                65,
                85,
                40
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
            this._moveList.Add(Bind.Instance);
            this._moveList.Add(PoisonSting.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(BubbleBeam.Instance);
            this._moveList.Add(Absorb.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(Constrict.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(Bubble.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Whirlpool.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(WaterSpout.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(Brine.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(OminousWind.Instance);
            this._moveList.Add(SludgeWave.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Hex.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(Poltergeist.Instance);
        }
        #endregion
    }
}