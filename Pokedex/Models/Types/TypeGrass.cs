namespace Pokedex.Models.Types
{
    internal class TypeGrass : PokeType
    {
        #region Variables
        /// <summary>
        /// Nullable variable (use of ? after type)
        /// </summary>
        private static TypeGrass? _instance = null;
        #endregion

        #region Getters + Setters
        /// <summary>
        /// If no instance, create it
        /// </summary>
        public static TypeGrass Instance
        {
            get { return _instance ?? (_instance = new TypeGrass()); }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Private constructor. Can't be called outside this class
        /// </summary>
        private TypeGrass()
            : base("Grass", "Plante", "9BCC50")
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
            this._typeAffinities.Add(TypeBug.Instance, 2);
            this._typeAffinities.Add(TypeFire.Instance, 2);
            this._typeAffinities.Add(TypeFlying.Instance, 2);
            this._typeAffinities.Add(TypeIce.Instance, 2);
            this._typeAffinities.Add(TypePoison.Instance, 2);
            this._typeAffinities.Add(TypeElectric.Instance, 0.5);
            this._typeAffinities.Add(TypeGrass.Instance, 0.5);
            this._typeAffinities.Add(TypeGround.Instance, 0.5);
            this._typeAffinities.Add(TypeWater.Instance, 0.5);
        }
        #endregion
    }
}
