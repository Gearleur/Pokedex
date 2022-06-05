using Pokedex.Models.Types;

namespace Pokedex.Models.Weathers
{
    internal class WeatherCloudy : Weather
    {
        #region Variables
        private static WeatherCloudy? _instance;
        #endregion

        #region Properties
        /// <summary>
        /// The singleton of the subclass
        /// </summary>
        public static WeatherCloudy Instance
        { get { return _instance ?? (_instance = new WeatherCloudy()); } }
        /* if (_instance == null)
         *     _instance = new WeatherClass();
         * return _instance;
         */
        #endregion

        #region Constructors
        protected WeatherCloudy() : base("Cloudy")
        {
            this._typePower.Add(TypeNormal.Instance, 1d);
        }
        #endregion

        #region Methods
        public override double OnDamageGive(double damage, PokeType type)
        {
			// All damage is reduced by 25%
			// Except Normal-type damage
            return this._typePower.GetValueOrDefault(type, 0.75d) * damage;
        }

        public override void OnTurnStart(Fight arena)
        {
            Console.WriteLine("The sky is cloudy.");
        }
        public override void OnEnter()
        {
            Console.WriteLine("The sky filled with clouds!");
        }
        public override void OnExit()
        {
            Console.WriteLine("The clouds disappeared.");
        }

        #endregion
    }
}