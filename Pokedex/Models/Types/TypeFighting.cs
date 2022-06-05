namespace Pokedex.Models.Types
{
    internal class TypeFighting : PokeType
    {
        #region Variables
        /// <summary>
        /// Nullable variable (use of ? after type)
        /// </summary>
        private static TypeFighting? _instance = null;
        #endregion

        #region Getters + Setters
        /// <summary>
        /// If no instance, create it
        /// </summary>
        public static TypeFighting Instance
        {
            get { return _instance ?? (_instance = new TypeFighting()); }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Private constructor. Can't be called outside this class
        /// </summary>
        private TypeFighting()
            : base("Fighting", "Combat", "D56723")
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
            this._typeAffinities.Add(TypeFairy.Instance, 2);
            this._typeAffinities.Add(TypeFlying.Instance, 2);
            this._typeAffinities.Add(TypePsy.Instance, 2);
            this._typeAffinities.Add(TypeBug.Instance, 0.5);
            this._typeAffinities.Add(TypeDark.Instance, 0.5);
            this._typeAffinities.Add(TypeRock.Instance, 0.5);
        }
        #endregion
    }
}
