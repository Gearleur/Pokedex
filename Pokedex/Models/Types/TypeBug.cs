namespace Pokedex.Models.Types
{
    internal class TypeBug : PokeType
    {
        #region Variables
        /// <summary>
        /// Nullable variable (use of ? after type)
        /// </summary>
        private static TypeBug? _instance = null;
        #endregion

        #region Getters + Setters
        /// <summary>
        /// If no instance, create it
        /// </summary>
        public static TypeBug Instance
        {
            get { return _instance ?? (_instance = new TypeBug()); }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Private constructor. Can't be called outside this class
        /// </summary>
        private TypeBug()
            : base("Bug", "Insecte", "729F3F")
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
            this._typeAffinities.Add(TypeFire.Instance, 2);
            this._typeAffinities.Add(TypeFlying.Instance, 2);
            this._typeAffinities.Add(TypeRock.Instance, 2);
            this._typeAffinities.Add(TypeFighting.Instance, 0.5);
            this._typeAffinities.Add(TypeGrass.Instance, 0.5);
            this._typeAffinities.Add(TypeGround.Instance, 0.5);
        }
        #endregion
    }
}
