using Pokedex.Enums;
using System.Text;

namespace Pokedex.Models
{
    internal class PokeInstance
    {
        #region Variables
        private Int32 _hp;
        private Int32 _level;

        private String _cry;
        private String _nickname;

        private Gender _gender;

        private Pokemon _pokemon;

        private PokeMove?[] _moves;
        #endregion

        #region Getters & Setters
        /// <summary>
        /// Pokemon's cry
        /// </summary>
        public String Cry
        {
            set { this._cry = value; }
        }

        /// <summary>
        /// Pokemon's gender
        /// </summary>
        public Gender Gender
        {
            get { return this._gender; }
        }

        /// <summary>
        /// Pokemon's health point
        /// </summary>
        public Int32 Hp
        {
            get { return this._hp; }
        }

        /// <summary>
        /// Pokemon's status ko / no ko
        /// </summary>
        public Boolean IsKo
        {
            get { return this._hp == 0; }
        }

        /// <summary>
        /// Pokemon's level
        /// </summary>
        public Int32 Level
        {
            get { return this._level; }
        }

        /// <summary>
        /// Pokemon's moves
        /// </summary>
        public PokeMove?[] Moves
        {
            get { return this._moves; }
        }

        /// <summary>
        /// Pokemon'snickname
        /// </summary>
        public String Nickname
        {
            get { return this._nickname; }
        }

        /// <summary>
        /// Pokemon's definition
        /// </summary>
        public Pokemon Pokemon
        {
            get { return _pokemon; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="pokemon">Pokemon meta</param>
        /// <param name="nickname">Pokemon nickname</param>
        /// <param name="level">Pokemon level</param>
        /// <param name="gender">Pokemon gender</param>
        public PokeInstance(Pokemon pokemon, string nickname, int level, Gender gender)
        {
            this._cry = nickname;
            this._gender = gender;
            this._nickname = nickname;
            this._pokemon = pokemon;

            // Check if level is between 1 and 100
            if (level < 1)
                this._level = 1;
            else if (level > 100)
                this._level = 100;
            else
                this._level = level;

			/* this._level = Math.Clamp(level, 1, 100) */

            // Set max hp
            this.Heal();

            // Init array for 4 moves
            this._moves = new PokeMove[4];
        }

        /// <summary>
        /// Constructor with custom health point
        /// </summary>
        /// <param name="pokemon">Pokemon meta</param>
        /// <param name="nickname">Pokemon nickname</param>
        /// <param name="level">Pokemon level</param>
        /// <param name="gender">Pokemon gender</param>
        /// <param name="hp">Pokemon health point</param>
        public PokeInstance(Pokemon pokemon, string nickname, int level, Gender gender, int hp)
            : this(pokemon, nickname, level, gender)
        {
            // Set custom hp
            // Check if more than 0 and less or equal than max hp
            if (hp >= 0 && hp <= this.CalcHp())
            {
                this._hp = hp;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Calc pokemon HP with hp stats and level properties
        /// </summary>
        /// <returns>Pokemon max health point</returns>
        public int CalcHp()
        {
            return (int)(this._pokemon.StatHp * 2 * this._level / 100.0 + this._level + 10);
            // hp stats * 2 * level / 100 + level + 10
        }

        /// <summary>
        /// Heal pokemon
        /// </summary>
        public void Heal()
        {
            this._hp = this.CalcHp();
        }

        /// <summary>
        /// Get pokemon's speed
        /// </summary>
        public int Speed()
        {
            return (int)(this._pokemon.StatSpeed) ;
        }

        /// <summary>
        /// Adds the move to the Pokemon's usables moves
        /// </summary>
        /// <param name="move">Move to learn</param>
        /// <returns>True if it succeeds, otherwise, false</returns>
        public bool LearnMove(PokeMove move)
        {
            /*if (this._moves[0] == null)
                this.LearnMove(move, 0);
            else if (this._moves[1] == null)
                this.LearnMove(move, 1);
            else if (this._moves[2] == null)
                this.LearnMove(move, 2);
            else
                this.LearnMove(move, 3);*/

            // Get the first index of null
			// If none are found, return -1
            Int32 position = this._moves.ToList().IndexOf(null);

			// If one is found, revert to the specific method
            if (position != -1)
                return this.LearnMove(move, position);
			// Else, do nothing and return false
            else
                return false;
        }

        /// <summary>
        /// Replaces a certain move (possibly null) with another
        /// </summary>
        /// <param name="move">Move to learn</param>
        /// <param name="position">Position to use</param>
        /// <returns>True if it succeeds, otherwise, false</returns>
        public bool LearnMove(PokeMove move, Int32 position)
        {
            // If the Pokemon's current moves do not contain the new move already
            if (!this._moves.Contains(move))
            {
                // If the new move is in the Pokemon's movepool
                if (this.Pokemon.MoveList.Contains(move))
                {
					// Adds this move
                    this._moves[position] = move;
					// Indicate that the operation succeeded
                    return true;
                }
            }
			// If any of the previous conditions fail, indicate that the operation failed
            return false;
        }

        /// <summary>
        /// Apply damage to pokemon
        /// Health point must be greater than 0
        /// </summary>
        /// <param name="damage"></param>
        public void TakeDamage(Int32 damage)
        {
			if (damage < 0)
				return;

            this._hp -= damage;

            if (this._hp < 0)
                this._hp = 0;
        }

        /// <summary>
        /// Return string which contains pokemon cry
        /// </summary>
        /// <returns>Pokemon cry</returns>
        public String Shout()
        {
            return String.Format("{0} says {1}!", this._nickname, this._cry);
        }

        /// <summary>
        /// Override default method toString
        /// </summary>
        /// <returns>Return pokemon description and information</returns>
        public override string ToString()
        {
            StringBuilder description = new StringBuilder();

            description.Append(this._pokemon);
            description.AppendLine();
            description.AppendFormat("\tHealth Points : {0}/{1} HP", this._hp, CalcHp());
            description.AppendLine();
            description.AppendFormat("\tShout : {0}", this.Shout());

            return description.ToString();
        }
        #endregion
    }
}

