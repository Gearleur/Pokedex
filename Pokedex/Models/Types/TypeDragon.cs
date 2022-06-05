namespace Pokedex.Models.Types
{
    internal class TypeDragon : PokeType
    {
        #region Variables
        /// <summary>
        /// Nullable variable (use of ? after type)
        /// </summary>
        private static TypeDragon? _instance = null;
        #endregion

        #region Getters + Setters
        /// <summary>
        /// If no instance, create it
        /// </summary>
        public static TypeDragon Instance
        {
            get { return _instance ?? (_instance = new TypeDragon()); }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Private constructor. Can't be called outside this class
        /// </summary>
        private TypeDragon()
            : base("Dragon", "Dragon", "F16E57")
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
            this._typeAffinities.Add(TypeDragon.Instance, 2);
            this._typeAffinities.Add(TypeFairy.Instance, 2);
            this._typeAffinities.Add(TypeIce.Instance, 2);
            this._typeAffinities.Add(TypeElectric.Instance, 0.5);
            this._typeAffinities.Add(TypeFire.Instance, 0.5);
            this._typeAffinities.Add(TypeGrass.Instance, 0.5);
            this._typeAffinities.Add(TypeWater.Instance, 0.5);
        }
        #endregion
    }
}
