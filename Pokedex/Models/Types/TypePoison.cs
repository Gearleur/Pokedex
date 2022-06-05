namespace Pokedex.Models.Types
{
    internal class TypePoison : PokeType
    {
        #region Variables
        /// <summary>
        /// Nullable variable (use of ? after type)
        /// </summary>
        private static TypePoison? _instance = null;
        #endregion

        #region Getters + Setters
        /// <summary>
        /// If no instance, create it
        /// </summary>
        public static TypePoison Instance
        {
            get { return _instance ?? (_instance = new TypePoison()); }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Private constructor. Can't be called outside this class
        /// </summary>
        private TypePoison()
            : base("Poison", "Poison", "B97FC9")
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
            this._typeAffinities.Add(TypePsy.Instance, 2);
            this._typeAffinities.Add(TypeBug.Instance, 0.5);
            this._typeAffinities.Add(TypeFairy.Instance, 0.5);
            this._typeAffinities.Add(TypeFighting.Instance, 0.5);
            this._typeAffinities.Add(TypeGrass.Instance, 0.5);
            this._typeAffinities.Add(TypePoison.Instance, 0.5);
        }
        #endregion
    }
}
