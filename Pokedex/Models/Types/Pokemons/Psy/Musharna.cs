// https://www.pokemon.com/us/pokedex/518

using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Psy
{
    internal class Musharna : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Musharna()); }
        }
        #endregion
        
        #region Constructors
        private Musharna()
            : base(
                518,
                "Musharna",
                "Mushana",
                TypePsy.Instance,
                11,
                605,
                "Drowsing Pokémon",
                "Pokémon Rêveur",
                "It drowses and dreams all the time. It’s best to leave it be if it’s just woken up, as it’s a terrible grump when freshly roused from sleep.",
                "Il est sans cesse assoupi, plongé dans ses rêves. Il vaut mieux éviter de le déranger, car il est toujours mal luné au réveil.",
                116,
                55,
                85,
                107,
                95,
                29
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
            this._moveList.Add(Psybeam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(FutureSight.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Psyshock.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(Moonblast.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(ExpandingForce.Instance);
            this._moveList.Add(MistyExplosion.Instance);
        }
        #endregion
    }
}