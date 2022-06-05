namespace Pokedex.Models.Types
{
    internal class TypeElectric : PokeType
    {
        #region Variables
        /// <summary>
        /// Nullable variable (use of ? after type)
        /// </summary>
        private static TypeElectric? _instance = null;
        #endregion

        #region Getters + Setters
        /// <summary>
        /// If no instance, create it
        /// </summary>
        public static TypeElectric Instance
        {
            get { return _instance ?? (_instance = new TypeElectric()); }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Private constructor. Can't be called outside this class
        /// </summary>
        private TypeElectric() 
            : base("Electric", "Electrik", "EED535")
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
            this._typeAffinities.Add(TypeGround.Instance, 2);
            this._typeAffinities.Add(TypeBug.Instance, 0.5);
            this._typeAffinities.Add(TypeElectric.Instance, 0.5);
            this._typeAffinities.Add(TypeFlying.Instance, 0.5);
            this._typeAffinities.Add(TypeSteel.Instance, 0.5);
        }
        #endregion
    }
}
