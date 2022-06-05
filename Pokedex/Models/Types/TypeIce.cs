namespace Pokedex.Models.Types
{
    internal class TypeIce : PokeType
    {
        #region Variables
        /// <summary>
        /// Nullable variable (use of ? after type)
        /// </summary>
        private static TypeIce? _instance = null;
        #endregion

        #region Getters + Setters
        /// <summary>
        /// If no instance, create it
        /// </summary>
        public static TypeIce Instance
        {
            get { return _instance ?? (_instance = new TypeIce()); }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Private constructor. Can't be called outside this class
        /// </summary>
        private TypeIce()
            : base("Ice", "Glace", "51C4E7")
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
            this._typeAffinities.Add(TypeFighting.Instance, 2);
            this._typeAffinities.Add(TypeFire.Instance, 2);
            this._typeAffinities.Add(TypeRock.Instance, 2);
            this._typeAffinities.Add(TypeSteel.Instance, 2);
            this._typeAffinities.Add(TypeIce.Instance, 0.5);
        }
        #endregion
    }
}
