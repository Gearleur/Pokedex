namespace Pokedex.Models.Types
{
    internal class TypeFlying : PokeType
    {
        #region Variables
        /// <summary>
        /// Nullable variable (use of ? after type)
        /// </summary>
        private static TypeFlying? _instance = null;
        #endregion

        #region Getters + Setters
        /// <summary>
        /// If no instance, create it
        /// </summary>
        public static TypeFlying Instance
        {
            get { return _instance ?? (_instance = new TypeFlying()); }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Private constructor. Can't be called outside this class
        /// </summary>
        private TypeFlying()
            : base("Flying", "Vol", "3DC7EF")
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
            this._typeAffinities.Add(TypeGround.Instance, 0);
            this._typeAffinities.Add(TypeElectric.Instance, 2);
            this._typeAffinities.Add(TypeIce.Instance, 2);
            this._typeAffinities.Add(TypeRock.Instance, 2);
            this._typeAffinities.Add(TypeBug.Instance, 0.5);
            this._typeAffinities.Add(TypeFighting.Instance, 0.5);
            this._typeAffinities.Add(TypeGrass.Instance, 0.5);
        }
        #endregion
    }
}
