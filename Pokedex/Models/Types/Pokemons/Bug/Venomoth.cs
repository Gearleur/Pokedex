// https://www.pokemon.com/us/pokedex/49

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Venomoth : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Venomoth()); }
        }
        #endregion
        
        #region Constructors
        private Venomoth()
            : base(
                49,
                "Venomoth",
                "Aéromite",
                TypeBug.Instance,
                TypePoison.Instance,
                15,
                125,
                "Poison Moth Pokémon",
                "Pokémon Papipoison",
                "The powdery scales on its wings are hard to remove from skin. They also contain poison that leaks out on contact.",
                "Les écailles de ses ailes sont presque impossibles à retirer lorsqu’elles se collent à la peau, et elles libèrent un poison violent au contact.",
                70,
                65,
                60,
                90,
                75,
                90
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
            this._moveList.Add(RazorWind.Instance);
            this._moveList.Add(Gust.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Psybeam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(MegaDrain.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Confusion.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(Rage.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(LeechLife.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Twister.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(PoisonFang.Instance);
            this._moveList.Add(AirCutter.Instance);
            this._moveList.Add(SilverWind.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(BugBuzz.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(OminousWind.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(StruggleBug.Instance);
            this._moveList.Add(Infestation.Instance);
        }
        #endregion
    }
}