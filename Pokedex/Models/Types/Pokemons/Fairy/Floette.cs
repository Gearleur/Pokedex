// https://www.pokemon.com/us/pokedex/670

using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fairy
{
    internal class Floette : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Floette()); }
        }
        #endregion
        
        #region Constructors
        private Floette()
            : base(
                670,
                "Floette",
                "Floette",
                TypeFairy.Instance,
                2,
                9,
                "Single Bloom Pokémon",
                "Pokémon Uniflore",
                "It gives its own power to flowers, pouring its heart into caring for them. Floette never forgives anyone who messes up a flower bed.",
                "Il fait profiter ses fleurs de ses pouvoirs et met tout son cœur à leur entretien. Gare à ceux qui ravagent ses plates-bandes !",
                54,
                45,
                47,
                75,
                98,
                52
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
            this._moveList.Add(VineWhip.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(RazorLeaf.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(PetalDance.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(PetalBlizzard.Instance);
            this._moveList.Add(FairyWind.Instance);
            this._moveList.Add(Moonblast.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
        }
        #endregion
    }
}