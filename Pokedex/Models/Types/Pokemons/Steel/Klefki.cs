// https://www.pokemon.com/us/pokedex/707

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Steel
{
    internal class Klefki : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Klefki()); }
        }
        #endregion
        
        #region Constructors
        private Klefki()
            : base(
                707,
                "Klefki",
                "Trousselin",
                TypeSteel.Instance,
                TypeFairy.Instance,
                2,
                30,
                "Key Ring Pokémon",
                "Pokémon Trousseau",
                "Klefki sucks in metal ions with the horn topping its head. It seems this Pokémon loves keys so much that its head needed to look like one, too.",
                "Il absorbe les ions métalliques avec l’appendice sur sa tête. Il paraît qu’il ressemble à une clé car il tient à imiter cet objet qu’il aime tant.",
                57,
                80,
                91,
                80,
                87,
                75
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
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(MirrorShot.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(Psyshock.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(DrainingKiss.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(FairyWind.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(SteelBeam.Instance);
        }
        #endregion
    }
}