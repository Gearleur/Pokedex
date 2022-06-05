using Pokedex.Models.Types;

namespace Pokedex.Models.Weathers
{
    internal class WeatherFog : Weather
    {
        #region Variables
        private static WeatherFog? _instance;
        #endregion

        #region Properties
        /// <summary>
        /// The singleton of the subclass
        /// </summary>
        public static WeatherFog Instance
        { get { return _instance ?? (_instance = new WeatherFog()); } }
        /* if (_instance == null)
         *     _instance = new WeatherClass();
         * return _instance;
         */
        #endregion

        #region Constructors
        protected WeatherFog() : base("Fog")
        {
            this._typePower.Add(TypeElectric.Instance, 0.5);
        }
        #endregion

        #region Methods

        public override void OnTurnStart(Fight arena)
        {
            Console.WriteLine("The fog is deep...");
        }
        public override void OnEnter()
        {
            Console.WriteLine("Fog crept up as thick as soup!");
        }
        public override void OnExit()
        {
            Console.WriteLine("The fog lifted.");
        }

        #endregion
    }
}