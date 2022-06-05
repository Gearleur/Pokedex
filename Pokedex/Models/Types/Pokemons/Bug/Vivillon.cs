// https://www.pokemon.com/us/pokedex/666

using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Vivillon : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Vivillon()); }
        }
        #endregion
        
        #region Constructors
        private Vivillon()
            : base(
                666,
                "Vivillon",
                "Prismillon",
                TypeBug.Instance,
                TypeFlying.Instance,
                12,
                170,
                "Scale Pokémon",
                "Pokémon Lépidécaille",
                "The patterns on this Pokémon’s wings depend on the climate and topography of its habitat. It scatters colorful scales.",
                "Selon le climat de sa région d’origine, les motifs de ses ailes sont différents. Il sème des écailles aux couleurs vives.",
                80,
                52,
                50,
                90,
                50,
                89
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
            this._moveList.Add(Gust.Instance);
            this._moveList.Add(Psybeam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(BugBuzz.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(StruggleBug.Instance);
            this._moveList.Add(Electroweb.Instance);
            this._moveList.Add(Hurricane.Instance);
            this._moveList.Add(DrainingKiss.Instance);
            this._moveList.Add(Infestation.Instance);
        }
        #endregion
    }
}