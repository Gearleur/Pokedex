namespace Pokedex.Models.Types
{
    internal class TypeGhost : PokeType
    {
        #region Variables
        /// <summary>
        /// Nullable variable (use of ? after type)
        /// </summary>
        private static TypeGhost? _instance = null;
        #endregion

        #region Getters + Setters
        /// <summary>
        /// If no instance, create it
        /// </summary>
        public static TypeGhost Instance
        {
            get { return _instance ?? (_instance = new TypeGhost()); }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Private constructor. Can't be called outside this class
        /// </summary>
        private TypeGhost()
            : base("Ghost", "Spectre", "7B62A3")
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
            this._typeAffinities.Add(TypeFighting.Instance, 0);
            this._typeAffinities.Add(TypeNormal.Instance, 0);
            this._typeAffinities.Add(TypeDark.Instance, 2);
            this._typeAffinities.Add(TypeGhost.Instance, 2);
            this._typeAffinities.Add(TypeBug.Instance, 0.5);
            this._typeAffinities.Add(TypePoison.Instance, 0.5);
        }
        #endregion
    }
}
