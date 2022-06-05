using Pokedex.Models.Types;

namespace Pokedex.Models.Weathers
{
    internal class WeatherSandstorm : Weather
    {
        #region Variables
        private static WeatherSandstorm? _instance;
        #endregion

        #region Properties
        /// <summary>
        /// The singleton of the subclass
        /// </summary>
        public static WeatherSandstorm Instance
        { get { return _instance ?? (_instance = new WeatherSandstorm()); } }
        /* if (_instance == null)
         *     _instance = new WeatherClass();
         * return _instance;
         */
        #endregion

        #region Constructors
        protected WeatherSandstorm() : base("Sandstorm")
        {
            this._typeSelector.Append(TypeRock.Instance);
            this._typeSelector.Append(TypeSteel.Instance);
            this._typeSelector.Append(TypeGround.Instance);
        }
        #endregion

        #region Methods
        public override void OnTurnEnd(Fight arena)
        {
            //Code
        }

        public override void OnTurnStart(Fight arena)
        {
            Console.WriteLine("The sandstorm rages.");
        }
        public override void OnEnter()
        {
            Console.WriteLine("A sandstorm kicked up!");
        }
        public override void OnExit()
        {
            Console.WriteLine("The sandstorm subsided.");
        }

        #endregion
    }
}