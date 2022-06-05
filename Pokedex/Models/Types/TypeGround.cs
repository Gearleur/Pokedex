namespace Pokedex.Models.Types
{
    internal class TypeGround : PokeType
    {
        #region Variables
        /// <summary>
        /// Nullable variable (use of ? after type)
        /// </summary>
        private static TypeGround? _instance = null;
        #endregion

        #region Getters + Setters
        /// <summary>
        /// If no instance, create it
        /// </summary>
        public static TypeGround Instance
        {
            get { return _instance ?? (_instance = new TypeGround()); }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Private constructor. Can't be called outside this class
        /// </summary>
        private TypeGround()
            : base("Ground", "Sol", "AB9842")
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
            this._typeAffinities.Add(TypeElectric.Instance, 0);
            this._typeAffinities.Add(TypeGrass.Instance, 2);
            this._typeAffinities.Add(TypeIce.Instance, 2);
            this._typeAffinities.Add(TypeWater.Instance, 2);
            this._typeAffinities.Add(TypePoison.Instance, 0.5);
            this._typeAffinities.Add(TypeRock.Instance, 0.5);
        }
        #endregion
    }
}
