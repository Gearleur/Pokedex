// https://www.pokemon.com/us/pokedex/832

using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Dubwool : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Dubwool()); }
        }
        #endregion
        
        #region Constructors
        private Dubwool()
            : base(
                832,
                "Dubwool",
                "Moumouflon",
                TypeNormal.Instance,
                13,
                430,
                "Sheep Pokémon",
                "Pokémon Mouton",
                "Its majestic horns are meant only to impress the opposite gender. They never see use in battle.",
                "Ses splendides cornes lui servent à attirer les membres de l’autre sexe. Il ne s’en sert jamais pour se battre.",
                72,
                80,
                100,
                60,
                90,
                88
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
            this._moveList.Add(DoubleKick.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(BodyPress.Instance);
            this._moveList.Add(GrassyGlide.Instance);
        }
        #endregion
    }
}