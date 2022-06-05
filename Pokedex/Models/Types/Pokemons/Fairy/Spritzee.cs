// https://www.pokemon.com/us/pokedex/682

using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fairy
{
    internal class Spritzee : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Spritzee()); }
        }
        #endregion
        
        #region Constructors
        private Spritzee()
            : base(
                682,
                "Spritzee",
                "Fluvetin",
                TypeFairy.Instance,
                2,
                5,
                "Perfume Pokémon",
                "Pokémon Fragrance",
                "The scent its body gives off enraptures those who smell it. Noble ladies had no shortage of love for Spritzee.",
                "Une douce odeur qui charme les gens émane de son corps. Les dames nobles raffolaient de lui.",
                78,
                52,
                60,
                63,
                65,
                23
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
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(DrainingKiss.Instance);
            this._moveList.Add(FairyWind.Instance);
            this._moveList.Add(Moonblast.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(MistyExplosion.Instance);
        }
        #endregion
    }
}