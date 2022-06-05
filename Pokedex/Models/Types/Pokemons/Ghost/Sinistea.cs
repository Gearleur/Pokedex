// https://www.pokemon.com/us/pokedex/854

using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ghost
{
    internal class Sinistea : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Sinistea()); }
        }
        #endregion
        
        #region Constructors
        private Sinistea()
            : base(
                854,
                "Sinistea",
                "Théffroi",
                TypeGhost.Instance,
                1,
                2,
                "Black Tea Pokémon",
                "Pokémon Thé Noir",
                "The teacup in which this Pokémon makes its home is a famous piece of antique tableware. Many forgeries are in circulation.",
                "Il élit domicile dans des tasses de thé anciennes de grand renom. Parmi celles-ci se trouvent de nombreuses contrefaçons.",
                40,
                45,
                45,
                74,
                54,
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
            this._moveList.Add(MegaDrain.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(Psyshock.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(Hex.Instance);
            this._moveList.Add(PhantomForce.Instance);
            this._moveList.Add(Poltergeist.Instance);
        }
        #endregion
    }
}