namespace Pokedex.Models.Weathers
{
    internal class WeatherClear : Weather
    {
        #region Variables
        private static WeatherClear? _instance;
        #endregion

        #region Properties
        /// <summary>
        /// The singleton of the subclass
        /// </summary>
        public static WeatherClear Instance
        { get { return _instance ?? (_instance = new WeatherClear()); } }
        /* if (_instance == null)
         *     _instance = new WeatherClass();
         * return _instance;
         */
        #endregion

        #region Constructors
        protected WeatherClear() : base("Clear") { }
        #endregion

        #region Methods
        public override void OnEnter()
        {
            Console.WriteLine("The sky clears up.");
        }

        #endregion
    }
}