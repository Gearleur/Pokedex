namespace Pokedex.Models.Types
{
    internal class TypeFairy : PokeType
    {
        #region Variables
        /// <summary>
        /// Nullable variable (use of ? after type)
        /// </summary>
        private static TypeFairy? _instance = null;
        #endregion

        #region Getters + Setters
        /// <summary>
        /// If no instance, create it
        /// </summary>
        public static TypeFairy Instance
        {
            get { return _instance ?? (_instance = new TypeFairy()); }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Private constructor. Can't be called outside this class
        /// </summary>
        private TypeFairy()
            : base("Fairy", "Fée", "FDB9E9")
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
            this._typeAffinities.Add(TypeDragon.Instance, 0);
            this._typeAffinities.Add(TypePoison.Instance, 2);
            this._typeAffinities.Add(TypeSteel.Instance, 2);
            this._typeAffinities.Add(TypeBug.Instance, 0.5);
            this._typeAffinities.Add(TypeDark.Instance, 0.5);
            this._typeAffinities.Add(TypeFighting.Instance, 0.5);
        }
        #endregion
    }
}
