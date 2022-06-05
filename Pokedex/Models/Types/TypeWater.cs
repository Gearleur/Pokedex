namespace Pokedex.Models.Types
{
    internal class TypeWater : PokeType
    {
        #region Variables
        /// <summary>
        /// Nullable variable (use of ? after type)
        /// </summary>
        private static TypeWater? _instance = null;
        #endregion

        #region Getters + Setters
        /// <summary>
        /// If no instance, create it
        /// </summary>
        public static TypeWater Instance
        {
            get { return _instance ?? (_instance = new TypeWater()); }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Private constructor. Can't be called outside this class
        /// </summary>
        private TypeWater()
            : base("Water", "Eau", "4592c4")
        { }
        #endregion

        #region Methods
        /// <summary>
        /// Implementation of the parent method
        /// </summary>
        /// <seealso cref="PokeType.InitTypeAffinities"/>
        protected override void InitTypeAffinities()
        {
            this._typeAffinities = new Dictionary<PokeType, double>();
            this._typeAffinities.Add(TypeElectric.Instance, 2);
            this._typeAffinities.Add(TypeGrass.Instance, 2);
            this._typeAffinities.Add(TypeFire.Instance, 0.5);
            this._typeAffinities.Add(TypeIce.Instance, 0.5);
            this._typeAffinities.Add(TypeSteel.Instance, 0.5);
            this._typeAffinities.Add(TypeWater.Instance, 0.5);
        }
        #endregion
    }
}
