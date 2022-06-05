// https://www.pokemon.com/us/pokedex/684

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fairy
{
    internal class Swirlix : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Swirlix()); }
        }
        #endregion
        
        #region Constructors
        private Swirlix()
            : base(
                684,
                "Swirlix",
                "Sucroquin",
                TypeFairy.Instance,
                4,
                35,
                "Cotton Candy Pokémon",
                "Pokémon Confiserie",
                "The sweet smell of cotton candy perfumes Swirlix’s fluffy fur. This Pokémon spits out sticky string to tangle up its enemies.",
                "Sa douce fourrure possède une odeur sucrée comme la barbe à papa. Il produit des filaments gluants pour empêtrer ses adversaires.",
                62,
                48,
                66,
                59,
                57,
                49
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
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(DrainingKiss.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(FairyWind.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(MistyExplosion.Instance);
        }
        #endregion
    }
}