using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models.Events
{
    internal class EventChangePokemon : Event
    {
        #region Variables
        private Trainer _player;
        private PokeInstance _newPokemon;
        #endregion

        #region Constructors
        /// <summary>
        /// The default constructor
        /// </summary>
        /// <param name="player">The player</param>
        /// <param name="pokemon">The pokemon</param>
        public EventChangePokemon(Trainer player, PokeInstance pokemon)
        {
            this._player = player;
            this._newPokemon = pokemon;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Change the pokemon
        /// </summary>
        public override void Todo()
        {
            if (this._newPokemon.IsKo)
            {
                return;
            }
            this._player.ActivePokemon = this._newPokemon;
        }
        #endregion
    }
}