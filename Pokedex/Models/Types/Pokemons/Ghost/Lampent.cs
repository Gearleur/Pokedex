// https://www.pokemon.com/us/pokedex/608

using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ghost
{
    internal class Lampent : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Lampent()); }
        }
        #endregion
        
        #region Constructors
        private Lampent()
            : base(
                608,
                "Lampent",
                "Mélancolux",
                TypeGhost.Instance,
                TypeFire.Instance,
                6,
                130,
                "Lamp Pokémon",
                "Pokémon Lampe",
                "It lurks in cities, pretending to be a lamp. Once it finds someone whose death is near, it will trail quietly after them.",
                "Il se cache en ville en se faisant passer pour un lampadaire. Lorsqu’il repère une personne dont l’heure est proche, il la suit en catimini.",
                60,
                40,
                60,
                95,
                60,
                55
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
            this._moveList.Add(Ember.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(FireSpin.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(Smog.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(Overheat.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(FlameBurst.Instance);
            this._moveList.Add(FlameCharge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Hex.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(Inferno.Instance);
            this._moveList.Add(MysticalFire.Instance);
            this._moveList.Add(SkitterSmack.Instance);
            this._moveList.Add(BurningJealousy.Instance);
            this._moveList.Add(Poltergeist.Instance);
        }
        #endregion
    }
}