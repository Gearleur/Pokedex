// https://www.pokemon.com/us/pokedex/333

using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Swablu : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Swablu()); }
        }
        #endregion
        
        #region Constructors
        private Swablu()
            : base(
                333,
                "Swablu",
                "Tylton",
                TypeNormal.Instance,
                TypeFlying.Instance,
                4,
                12,
                "Cotton Bird Pokémon",
                "Pokémon Oiseaucoton",
                "Since Swablu looks like a cumulus cloud, foes can have a hard time finding it. Apparently its wings turned white over many generations.",
                "Ses ailes en forme de nuage le dissimulent aux yeux des ennemis. On raconte qu’elles sont devenues blanches après plusieurs générations.",
                45,
                40,
                60,
                40,
                75,
                50
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
            this._moveList.Add(FuryAttack.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Rage.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(SkyAttack.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(Outrage.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(SteelWing.Instance);
            this._moveList.Add(DragonBreath.Instance);
            this._moveList.Add(Pursuit.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Twister.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(AirCutter.Instance);
            this._moveList.Add(Pluck.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(DragonRush.Instance);
            this._moveList.Add(OminousWind.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(Moonblast.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}