// https://www.pokemon.com/us/pokedex/857

using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Psy
{
    internal class Hattrem : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Hattrem()); }
        }
        #endregion
        
        #region Constructors
        private Hattrem()
            : base(
                857,
                "Hattrem",
                "Chapotus",
                TypePsy.Instance,
                6,
                48,
                "Serene Pokémon",
                "Pokémon Serein",
                "Using the braids on its head, it pummels foes to get them to quiet down. One blow from those braids would knock out a professional boxer.",
                "Il frappe ses ennemis avec ses tresses pour les faire taire. Sa puissance est telle qu’il peut mettre K.O. un boxeur professionnel d’un seul coup.",
                57,
                40,
                65,
                86,
                73,
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
            this._moveList.Add(Psybeam.Instance);
            this._moveList.Add(Confusion.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(Psyshock.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(DrainingKiss.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(MysticalFire.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(ExpandingForce.Instance);
        }
        #endregion
    }
}