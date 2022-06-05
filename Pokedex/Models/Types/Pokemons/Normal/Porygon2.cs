// https://www.pokemon.com/us/pokedex/233

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Porygon2 : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Porygon2()); }
        }
        #endregion
        
        #region Constructors
        private Porygon2()
            : base(
                233,
                "Porygon2",
                "Porygon2",
                TypeNormal.Instance,
                6,
                325,
                "Virtual Pokémon",
                "Pokémon Virtuel",
                "After artificial intelligence was implemented in Porygon2, the Pokémon began using a strange language that only other Porygon2 understand.",
                "Depuis qu’on l’a doté d’une intelligence artificielle, il parle un langage mystérieux que seuls ses congénères comprennent.",
                85,
                80,
                90,
                105,
                95,
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
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(Psybeam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(ThunderShock.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(TriAttack.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(ZapCannon.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(Discharge.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Psyshock.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Electroweb.Instance);
        }
        #endregion
    }
}