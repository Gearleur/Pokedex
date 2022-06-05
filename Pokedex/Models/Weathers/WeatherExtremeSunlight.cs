using Pokedex.Models.Types;

namespace Pokedex.Models.Weathers
{
    internal class WeatherExtremeSunlight : Weather
    {
        #region Variables
        private static WeatherExtremeSunlight? _instance;
        #endregion

        #region Properties
        /// <summary>
        /// The singleton of the subclass
        /// </summary>
        public static WeatherExtremeSunlight Instance
        { get { return _instance ?? (_instance = new WeatherExtremeSunlight()); } }
        /* if (_instance == null)
         *     _instance = new WeatherClass();
         * return _instance;
         */
        #endregion

        #region Constructors
        protected WeatherExtremeSunlight() : base("Extremely Harsh Sunlight")
        {
            this._typePower.Add(TypeFire.Instance, 1.5d);
            this._typePower.Add(TypeWater.Instance, 0d);
        }
        #endregion

        #region Methods
        public override void OnTurnStart(Fight arena)
        {
            Console.WriteLine("The sunlight is  extremely strong.");
        }
        public override void OnEnter()
        {
            Console.WriteLine("The sunlight turned extremely harsh!");
        }
        public override void OnExit()
        {
            Console.WriteLine("The extremely harsh sunlight faded.");
        }

        #endregion
    }
}