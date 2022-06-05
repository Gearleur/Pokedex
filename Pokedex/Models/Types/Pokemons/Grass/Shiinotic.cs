// https://www.pokemon.com/us/pokedex/756

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Shiinotic : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Shiinotic()); }
        }
        #endregion
        
        #region Constructors
        private Shiinotic()
            : base(
                756,
                "Shiinotic",
                "Lampignon",
                TypeGrass.Instance,
                TypeFairy.Instance,
                10,
                115,
                "Illuminating Pokémon",
                "Pokémon Luminescent",
                "If you see a light deep in a forest at night, don’t go near. Shiinotic will make you fall fast asleep.",
                "Il ne faut pas s’approcher des lumières qui luisent la nuit au fond des bois, sous peine de se faire endormir par un Lampignon.",
                60,
                45,
                80,
                90,
                100,
                30
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
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Absorb.Instance);
            this._moveList.Add(MegaDrain.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(DrainingKiss.Instance);
            this._moveList.Add(Moonblast.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(PollenPuff.Instance);
        }
        #endregion
    }
}