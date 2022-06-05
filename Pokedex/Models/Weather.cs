namespace Pokedex.Models
{
    /// <summary>
    /// A weather effect happening during a fight
    /// </summary>
    internal abstract class Weather
    {
        #region Variables
        private String _name;

        /// <summary>
        /// Used for damage buff/debuff based on type
        /// </summary>
        protected Dictionary<PokeType, double> _typePower;

        /// <summary>
        /// Used for damaging weathers
        /// </summary>
        protected PokeType[] _typeSelector;
        #endregion

        #region Getters + Setters
        /// <summary>
        /// The display name of the Weather
        /// </summary>
        public String Name { get => this._name; }
		#endregion

        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="name">Weather's name</param>
        protected Weather(String name)
        {
            this._name = name;
            this._typePower = new Dictionary<PokeType, double>();
            this._typeSelector = new PokeType[] { };
        }
        #endregion

        #region Methods
        /// <summary>
        /// Use _typePower to buff/debuff the damage<br/>
        /// If _typePower does not define an interaction for the type, do nothing
        /// </summary>
        /// <param name="damage">The base damage</param>
        /// <param name="type">The type of the damage</param>
        /// <returns>The modified damage</returns>
        public virtual double OnDamageGive(double damage, PokeType type)
        {
            return this._typePower.GetValueOrDefault(type, 1) * damage;

            /* if (this._typePower.ContainsKey(type))
             *     return damage * this._typePower[type];
             * return damage;
             */
        }

        /// <summary>
        /// Called at a weather change, when this is the new weather
        /// </summary>
        public virtual void OnEnter() { }

        /// <summary>
        /// Called at a weather change, when this is the old weather
        /// </summary>
        public virtual void OnExit() { }

        /// <summary>
        /// Called at the beginning of a turn
        /// </summary>
        public virtual void OnTurnStart(Fight arena) { }

		/// <summary>
		/// Called at the end of a turn
		/// </summary>
		/// <param name="arena">The fight in which the weather is active</param>
        public virtual void OnTurnEnd(Fight arena) { }
        #endregion
    }
}