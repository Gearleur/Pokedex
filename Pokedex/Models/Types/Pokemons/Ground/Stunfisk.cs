// https://www.pokemon.com/us/pokedex/618

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ground
{
    internal class Stunfisk : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Stunfisk()); }
        }
        #endregion
        
        #region Constructors
        private Stunfisk()
            : base(
                618,
                "Stunfisk",
                "Limonde",
                TypeGround.Instance,
                TypeElectric.Instance,
                7,
                110,
                "Trap Pokémon",
                "Pokémon Piège",
                "For some reason, this Pokémon smiles slightly when it emits a strong electric current from the yellow markings on its body.",
                "Lorsque les parties jaunes de son corps envoient une puissante décharge électrique, il ébauche un sourire. Personne ne sait pourquoi.",
                109,
                66,
                84,
                81,
                99,
                32
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
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(ThunderShock.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(Spark.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(MuddyWater.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(MudBomb.Instance);
            this._moveList.Add(Discharge.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(SludgeWave.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(Electroweb.Instance);
            this._moveList.Add(Infestation.Instance);
            this._moveList.Add(StompingTantrum.Instance);
            this._moveList.Add(LashOut.Instance);
        }
        #endregion
    }
}