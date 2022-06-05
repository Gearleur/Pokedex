namespace Pokedex.Models.Types
{
    internal class TypeDark : PokeType
    {
        #region Variables
        /// <summary>
        /// Nullable variable (use of ? after type)
        /// </summary>
        private static TypeDark? _instance = null;
        #endregion

        #region Getters + Setters
        /// <summary>
        /// If no instance, create it
        /// </summary>
        public static TypeDark Instance
        {
            get { return _instance ?? (_instance = new TypeDark()); }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Private constructor. Can't be called outside this class
        /// </summary>
        private TypeDark()
            : base("Dark", "Ténèbres", "707070")
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
            this._typeAffinities.Add(TypePsy.Instance, 0);
            this._typeAffinities.Add(TypeBug.Instance, 2);
            this._typeAffinities.Add(TypeFairy.Instance, 2);
            this._typeAffinities.Add(TypeFighting.Instance, 2);
            this._typeAffinities.Add(TypeDark.Instance, 0.5);
            this._typeAffinities.Add(TypeGhost.Instance, 0.5);
        }
        #endregion
    }
}
