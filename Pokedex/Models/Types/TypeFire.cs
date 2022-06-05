namespace Pokedex.Models.Types
{
    internal class TypeFire : PokeType
    {
        #region Variables
        /// <summary>
        /// Nullable variable (use of ? after type)
        /// </summary>
        private static TypeFire? _instance = null;
        #endregion

        #region Getters + Setters
        /// <summary>
        /// If no instance, create it
        /// </summary>
        public static TypeFire Instance
        {
            get { return _instance ?? (_instance = new TypeFire()); }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Private constructor. Can't be called outside this class
        /// </summary>
        private TypeFire()
            : base("Fire", "Feu", "FD7D24")
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
            this._typeAffinities.Add(TypeRock.Instance, 2);
            this._typeAffinities.Add(TypeWater.Instance, 2);
            this._typeAffinities.Add(TypeBug.Instance, 0.5);
            this._typeAffinities.Add(TypeFairy.Instance, 0.5);
            this._typeAffinities.Add(TypeFire.Instance, 0.5);
            this._typeAffinities.Add(TypeGrass.Instance, 0.5);
            this._typeAffinities.Add(TypeIce.Instance, 0.5);
            this._typeAffinities.Add(TypeSteel.Instance, 0.5);
        }
        #endregion
    }
}
