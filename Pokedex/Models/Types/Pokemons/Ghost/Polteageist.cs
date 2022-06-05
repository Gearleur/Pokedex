// https://www.pokemon.com/us/pokedex/855

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ghost
{
    internal class Polteageist : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Polteageist()); }
        }
        #endregion
        
        #region Constructors
        private Polteageist()
            : base(
                855,
                "Polteageist",
                "Polthégeist",
                TypeGhost.Instance,
                2,
                4,
                "Black Tea Pokémon",
                "Pokémon Thé Noir",
                "Leaving leftover black tea unattended is asking for this Pokémon to come along and pour itself into it, turning the tea into a new Polteageist.",
                "Dès qu’il voit un reste de thé noir, il se verse dedans pour donner naissance à un Polthégeist.",
                60,
                65,
                65,
                134,
                114,
                70
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
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(MegaDrain.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(SelfDestruct.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(GigaImpact.Instance);
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