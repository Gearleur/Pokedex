// https://www.pokemon.com/us/pokedex/764

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fairy
{
    internal class Comfey : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Comfey()); }
        }
        #endregion
        
        #region Constructors
        private Comfey()
            : base(
                764,
                "Comfey",
                "Guérilande",
                TypeFairy.Instance,
                1,
                3,
                "Posy Picker Pokémon",
                "Pokémon Tressefleur",
                "These Pokémon smell very nice. All Comfey wear different flowers, so each of these Pokémon has its own individual scent.",
                "Ce Pokémon dégage un parfum agréable qui varie d’un spécimen à l’autre, car chaque Guérilande s’habille de fleurs différentes.",
                51,
                52,
                90,
                82,
                110,
                100
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
            this._moveList.Add(Bind.Instance);
            this._moveList.Add(VineWhip.Instance);
            this._moveList.Add(Wrap.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(PetalDance.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(LeafTornado.Instance);
            this._moveList.Add(PetalBlizzard.Instance);
            this._moveList.Add(DrainingKiss.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(PollenPuff.Instance);
            this._moveList.Add(GrassyGlide.Instance);
        }
        #endregion
    }
}