// https://www.pokemon.com/us/pokedex/885

using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Dragon
{
    internal class Dreepy : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Dreepy()); }
        }
        #endregion
        
        #region Constructors
        private Dreepy()
            : base(
                885,
                "Dreepy",
                "Fantyrm",
                TypeDragon.Instance,
                TypeGhost.Instance,
                5,
                20,
                "Lingering Pokémon",
                "Pokémon Âme Errante",
                "If this weak Pokémon is by itself, a mere child could defeat it. But if Dreepy has friends to help it train, it can evolve and become much stronger.",
                "Seul, il est si faible qu’il ne saurait rivaliser avec un enfant, mais en coopérant avec ses semblables, il peut devenir assez fort pour évoluer.",
                28,
                60,
                30,
                40,
                30,
                82
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
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(DracoMeteor.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(DragonTail.Instance);
            this._moveList.Add(Infestation.Instance);
        }
        #endregion
    }
}