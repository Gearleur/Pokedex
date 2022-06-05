namespace Pokedex.Models.Types
{
    internal class TypeNormal : PokeType
    {
        #region Variables
        /// <summary>
        /// Nullable variable (use of ? after type)
        /// </summary>
        private static TypeNormal? _instance = null;
        #endregion

        #region Getters + Setters
        /// <summary>
        /// If no instance, create it
        /// </summary>
        public static TypeNormal Instance
        {
            get { return _instance ?? (_instance = new TypeNormal()); }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Private constructor. Can't be called outside this class
        /// </summary>
        private TypeNormal()
            : base("Normal", "Normal", "A4ACAF")
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
            this._typeAffinities.Add(TypeGhost.Instance, 0);
            this._typeAffinities.Add(TypeFighting.Instance, 2);
        }
        #endregion
    }
}
