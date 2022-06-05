using Pokedex.Models.Types;

namespace Pokedex.Models.Weathers
{
    internal class WeatherHail : Weather
    {
        #region Variables
        private static WeatherHail? _instance;
        #endregion

        #region Properties
        /// <summary>
        /// The singleton of the subclass
        /// </summary>
        public static WeatherHail Instance
        { get { return _instance ?? (_instance = new WeatherHail()); } }
        /* if (_instance == null)
         *     _instance = new WeatherClass();
         * return _instance;
         */
        #endregion

        #region Constructors
        protected WeatherHail() : base("Hail")
        {
            this._typeSelector.Append(TypeIce.Instance);
        }
        #endregion

        #region Methods
        public override void OnTurnEnd(Fight arena)
        {
            //Code
        }

        public override void OnTurnStart(Fight arena)
        {
            Console.WriteLine("Hail continues to fall.");
        }
        public override void OnEnter()
        {
            Console.WriteLine("It started to hail!");
        }
        public override void OnExit()
        {
            Console.WriteLine("The hail stopped.");
        }

        #endregion
    }
}