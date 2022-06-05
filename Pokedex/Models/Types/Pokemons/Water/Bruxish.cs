// https://www.pokemon.com/us/pokedex/779

using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Bruxish : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Bruxish()); }
        }
        #endregion
        
        #region Constructors
        private Bruxish()
            : base(
                779,
                "Bruxish",
                "Denticrisse",
                TypeWater.Instance,
                TypePsy.Instance,
                9,
                190,
                "Gnash Teeth Pokémon",
                "Pokémon Grincedent",
                "Its skin is thick enough to fend off Mareanie’s spikes. With its robust teeth, Bruxish crunches up the spikes and eats them.",
                "Sa peau est si épaisse que même les épines de Vorastérie ne peuvent la percer. Il les croque bruyamment grâce à ses dents solides.",
                68,
                105,
                70,
                70,
                70,
                92
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
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(Confusion.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(Rage.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(PoisonFang.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(IceFang.Instance);
            this._moveList.Add(AquaJet.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(Synchronoise.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(FrostBreath.Instance);
            this._moveList.Add(PsychicFangs.Instance);
            this._moveList.Add(Liquidation.Instance);
        }
        #endregion
    }
}