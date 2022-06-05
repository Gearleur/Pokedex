using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models.Events
{
    internal class EventMove : Event
    {
        #region Variables
        private PokeInstance _pokemon;
        private PokeMove _move;
        #endregion

        #region Constructors
        /// <summary>
        /// The default constructor
        /// </summary>
        /// <param name="pokemon">The pokemon</param>
        /// <param name="move">The move</param>
        public EventMove(PokeInstance pokemon, PokeMove move)
        {
            this._pokemon = pokemon;
            this._move = move;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Do the move
        /// </summary>
        public override void Todo()
        {
            if (this._pokemon.IsKo)
            {
                return;
            }
            
        }

        public PokeMove Move
        {
            get { return this._move; }
        }
        #endregion
    }
}