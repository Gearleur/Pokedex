using Pokedex.Models.Types;

namespace Pokedex.Models.Weathers
{
    internal class WeatherHeavyRain : Weather
    {
        #region Variables
        private static WeatherHeavyRain? _instance;
        #endregion

        #region Properties
        /// <summary>
        /// The singleton of the subclass
        /// </summary>
        public static WeatherHeavyRain Instance
        { get { return _instance ?? (_instance = new WeatherHeavyRain()); } }
        /* if (_instance == null)
         *     _instance = new WeatherClass();
         * return _instance;
         */
        #endregion

        #region Constructors
        protected WeatherHeavyRain() : base("Rain")
        {
            this._typePower.Add(TypeWater.Instance, 1.5d);
            this._typePower.Add(TypeFire.Instance, 0d);
        }
        #endregion

        #region Methods
        public override void OnTurnStart(Fight arena)
        {
            Console.WriteLine("The heavy rain continues to fall.");
        }
        public override void OnEnter()
        {
            Console.WriteLine("A heavy rain began to fall.");
        }
        public override void OnExit()
        {
            Console.WriteLine("The heavy rain has lifted.");
        }

        #endregion
    }
}