using Pokedex.Models.Types;

namespace Pokedex.Models.Weathers
{
    internal class WeatherRain : Weather
    {
        #region Variables
        private static WeatherRain? _instance;
        #endregion

        #region Properties
        /// <summary>
        /// The singleton of the subclass
        /// </summary>
        public static WeatherRain Instance
        { get { return _instance ?? (_instance = new WeatherRain()); } }
        /* if (_instance == null)
         *     _instance = new WeatherClass();
         * return _instance;
         */
        #endregion

        #region Constructors
        protected WeatherRain() : base("Rain")
        {
            this._typePower.Add(TypeWater.Instance, 1.5d);
            this._typePower.Add(TypeFire.Instance, 0.5d);
        }
        #endregion

        #region Methods
        public override void OnTurnStart(Fight arena)
        {
            Console.WriteLine("Rain continues to fall.");
        }
        public override void OnEnter()
        {
            Console.WriteLine("It started to rain.");
        }
        public override void OnExit()
        {
            Console.WriteLine("The rain stopped.");
        }

        #endregion
    }
}