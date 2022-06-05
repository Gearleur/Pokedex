// https://www.pokemon.com/us/pokedex/827

using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Dark
{
    internal class Nickit : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Nickit()); }
        }
        #endregion
        
        #region Constructors
        private Nickit()
            : base(
                827,
                "Nickit",
                "Goupilou",
                TypeDark.Instance,
                6,
                89,
                "Fox Pokémon",
                "Pokémon Renard",
                "Cunning and cautious, this Pokémon survives by stealing food from others. It erases its tracks with swipes of its tail as it makes off with its plunder.",
                "Rusé et vigilant, il prend la poudre d’escampette après avoir volé de la nourriture en prenant soin d’effacer ses traces de pas avec sa queue.",
                40,
                28,
                28,
                47,
                52,
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
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(NightSlash.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(TailSlap.Instance);
            this._moveList.Add(Snarl.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(LashOut.Instance);
        }
        #endregion
    }
}