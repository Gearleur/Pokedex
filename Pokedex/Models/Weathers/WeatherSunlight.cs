using Pokedex.Models.Types;

namespace Pokedex.Models.Weathers
{
    internal class WeatherSunlight : Weather
    {
        #region Variables
        private static WeatherSunlight? _instance;
        #endregion

        #region Properties
        /// <summary>
        /// The singleton of the subclass
        /// </summary>
        public static WeatherSunlight Instance
        { get { return _instance ?? (_instance = new WeatherSunlight()); } }
        /* if (_instance == null)
         *     _instance = new WeatherClass();
         * return _instance;
         */
        #endregion

        #region Constructors
        protected WeatherSunlight() : base("Harsh Sunlight")
        {
            this._typePower.Add(TypeFire.Instance, 1.5d);
            this._typePower.Add(TypeWater.Instance, 0.5d);
        }
        #endregion

        #region Methods
        public override void OnTurnStart(Fight arena)
        {
            Console.WriteLine("The sunlight is strong.");
        }
        public override void OnEnter()
        {
            Console.WriteLine("The sunlight turned harsh!");
        }
        public override void OnExit()
        {
            Console.WriteLine("The harsh sunlight faded.");
        }

        #endregion
    }
}