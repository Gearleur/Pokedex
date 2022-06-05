using Pokedex.Enums;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Pokedex.Models
{
    internal abstract class Pokemon
    {
        #region Variables
        private Int32 _id;
        private String _nameEn;
        private String _nameFr;

        /* Gameplay */
        protected List<PokeMove>? _moveList;
        private PokeType _type;
        private PokeType? _typeSecond;

        /* Stats */
        private Int32 _statAttack;
        private Int32 _statDefense;
        private Int32 _statHp;
        private Int32 _statSpecialAttack;
        private Int32 _statSpecialDefense;
        private Int32 _statSpeed;

        /* Flavor */
        private String _descriptionEn;
        private String _descriptionFr;
        private String _genusEn;
        private String _genusFr;
        private Double _height;
        private Double _weight;
        #endregion

        #region Getters & Setters
        /// <summary>
        /// Pokemon's english description
        /// </summary>
        public String DescriptionEn
        {
            get { return this._descriptionEn; }
        }

        /// <summary>
        /// Pokemon's french description
        /// </summary>
        public String DescriptionFr
        {
            get { return this._descriptionFr; }
        }

        /// <summary>
        /// Pokemon's english genus
        /// </summary>
        public String GenusEn
        {
            get { return this._genusEn; }
        }

        /// <summary>
        /// Pokemon's french genus
        /// </summary>
        public String GenusFr
        {
            get { return this._genusFr; }
        }

        /// <summary>
        /// Pokemon's height
        /// </summary>
        public Double Height
        {
            get { return this._height; }
        }

        /// <summary>
        /// Pokemon's id
        /// </summary>
        public Int32 Id
        {
            get { return this._id; }
        }

        /// <summary>
        /// Moves that this Pokemon is allowed to learn
        /// </summary>
        public List<PokeMove> MoveList
        {
            get
            {
                // If the list is not yet initialized
                if (this._moveList == null)
                    // Initialize it as defined in the child class
                    this.InitMoveList();

                return this._moveList;
            }
        }

        /// <summary>
        /// Pokemon's name (french and english)
        /// </summary>
        public String Name
        {
            get { return String.Format("{0} ({1})", this._nameFr, this._nameEn); }
        }

        /// <summary>
        /// Pokemon's english name
        /// </summary>
        public String NameEn
        {
            get { return this._nameEn; }
        }

        /// <summary>
        /// Pokemon's french name
        /// </summary>
        public String NameFr
        {
            get { return this._nameFr; }
        }

        /// <summary>
        /// Pokemon's stat Attack
        /// </summary>
        public Int32 StatAttack
        {
            get { return this._statAttack; }
        }


        /// <summary>
        /// Pokemon's stat Defense
        /// </summary>
        public Int32 StatDefense
        {
            get { return this._statDefense; }
        }

        /// <summary>
        /// Pokemon's health point stats
        /// </summary>
        public Int32 StatHp
        {
            get { return this._statHp; }
        }

        /// <summary>
        /// Pokemon's Special Attack stat
        /// </summary>
        public Int32 StatSpecialAttack
        {
            get { return this._statSpecialAttack; }
        }

        /// <summary>
        /// Pokemon's Special Defense stat
        /// </summary>
        public Int32 StatSpecialDefense
        {
            get { return this._statSpecialDefense; }
        }

        /// <summary>
        /// Pokemon's Speed stat
        /// </summary>
        public Int32 StatSpeed
        {
            get { return this._statSpeed; }
        }

        /// <summary>
        /// Pokemon's types
        /// </summary>
        public (PokeType, PokeType?) Types
        {
            get { return (this._type, this._typeSecond); }
        }

        /// <summary>
        /// Pokemon's weight
        /// </summary>
        public Double Weight
        {
            get { return this._weight; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="descriptionEn">Pokemon english description</param>
        /// <param name="descriptionFr">Pokemon french description</param>
        /// <param name="genusEn">Pokemon english genus</param>
        /// <param name="genusFr">Pokemon french genus</param>
        /// <param name="height">Pokemon height</param>
        /// <param name="id">Pokemon id</param>
        /// <param name="nameEn">Pokemon english name</param>
        /// <param name="nameFr">Pokemon french name</param>
        /// <param name="statAttack">Pokemon attack stat</param>
        /// <param name="statDefense">Pokemon defense stat</param>
        /// <param name="statHp">Pokemon HP stat</param>
        /// <param name="statSpecialAttack">Pokemon special attack stat</param>
        /// <param name="statSpecialDefense">Pokemon special defense stat</param>
        /// <param name="statSpeed">Pokemon speed stat</param>
        /// <param name="type">Pokemon type</param>
        /// <param name="weight">Pokemon weight</param>
        public Pokemon
        (
            Int32 id,
            String nameEn,
            String nameFr,
            PokeType type,
            Int32 height,
            Int32 weight,
            String genusEn,
            String genusFr,
            String descriptionEn,
            String descriptionFr,
            Int32 statHp,
            Int32 statAttack,
            Int32 statDefense,
            Int32 statSpecialAttack,
            Int32 statSpecialDefense,
            Int32 statSpeed
        )
        {
            this._moveList = null;
            this._descriptionEn = descriptionEn;
            this._descriptionFr = descriptionFr;
            this._genusEn = genusEn;
            this._genusFr = genusFr;
            this._id = id;
            this._nameEn = nameEn;
            this._nameFr = nameFr;
            this._height = height;
            this._statAttack = statAttack;
            this._statDefense = statDefense;
            this._statHp = statHp;
            this._statSpecialAttack = statSpecialAttack;
            this._statSpecialDefense = statSpecialDefense;
            this._statSpeed = statSpeed;
            this._type = type;
            this._typeSecond = null;
            this._weight = weight;
        }

        /// <summary>
        /// Extend the default constructor to take a second type
        /// </summary>
        /// <param name="descriptionEn">Pokemon english description</param>
        /// <param name="descriptionFr">Pokemon french description</param>
        /// <param name="genusEn">Pokemon english genus</param>
        /// <param name="genusFr">Pokemon french genus</param>
        /// <param name="height">Pokemon height</param>
        /// <param name="id">Pokemon id</param>
        /// <param name="nameEn">Pokemon english name</param>
        /// <param name="nameFr">Pokemon french name</param>
        /// <param name="statAttack">Pokemon attack stat</param>
        /// <param name="statDefense">Pokemon defense stat</param>
        /// <param name="statHp">Pokemon HP stat</param>
        /// <param name="statSpecialAttack">Pokemon special attack stat</param>
        /// <param name="statSpecialDefense">Pokemon special defense stat</param>
        /// <param name="statSpeed">Pokemon speed stat</param>
        /// <param name="type">Pokemon type</param>
        /// <param name="weight">Pokemon weight</param>
        /// <inheritdoc cref="Pokemon(Int32, String, String, PokeType, Int32, Int32, Int32, Int32, Int32, Int32, String, String, String, String, Int32, Int32)"/>
        public Pokemon
        (
            Int32 id,
            String nameEn,
            String nameFr,
            PokeType type,
            PokeType typeSecond,
            Int32 height,
            Int32 weight,
            String genusEn,
            String genusFr,
            String descriptionEn,
            String descriptionFr,
            Int32 statHp,
            Int32 statAttack,
            Int32 statDefense,
            Int32 statSpecialAttack,
            Int32 statSpecialDefense,
            Int32 statSpeed
        ) : this(
            id,
            nameEn,
            nameFr,
            type,
            height,
            weight,
            genusEn,
            genusFr,
            descriptionEn,
            descriptionFr,
            statHp,
            statAttack,
            statDefense,
            statSpecialAttack,
            statSpecialDefense,
            statSpeed
        )
        {
            this._typeSecond = typeSecond;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Gets the Pokemon's generation based on its ID
        /// </summary>
        /// <returns>Number ranging from 1 to 8</returns>
        public Int32 GetGeneration()
        {
            if (this._id <= 151)
                return 1;
            else if (this._id <= 251)
                return 2;
            else if (this._id <= 386)
                return 3;
            else if (this._id <= 493)
                return 4;
            else if (this._id <= 649)
                return 5;
            else if (this._id <= 721)
                return 6;
            else if (this._id <= 809)
                return 7;
            else
                return 8;
        }

        /// <summary>
		/// Initializes the _canLearn field
        /// </summary>
		/// <paramref name="_canLearn"/>
		/// <remarks>Abstract</remarks>
        [MemberNotNull(nameof(_moveList))]
        public abstract void InitMoveList();

        /// <summary>
        /// Override of the default ToString method
        /// </summary>
        /// <returns>Pokedex-like description of the Pokemon</returns>
        public override string ToString()
        {
            StringBuilder pokedex = new StringBuilder();

            // Add name
            pokedex.Append(this.Name);
            pokedex.AppendLine();

            // Add Id
            pokedex.AppendFormat("\tID : {0}", this._id);
            pokedex.AppendLine();

            // Add Generation
            pokedex.AppendFormat("\tGen : {0}", this.GetGeneration());
            pokedex.AppendLine();

            // Add Type(s)
            pokedex.AppendFormat("\tType : {0}", this._type.Name);
            if (this._typeSecond != null)
                pokedex.AppendFormat(" - {0}", this._typeSecond.Name);
            pokedex.AppendLine();

            // Add Weight
            pokedex.AppendFormat("\tWeight : {0} kg", this._weight);
            pokedex.AppendLine();

            // Add Height
            pokedex.AppendFormat("\tHeight : {0} cm", this._height);
            pokedex.AppendLine();

            // Add Description
            pokedex.AppendFormat("\tDescription : {0}", this._descriptionEn);

            return pokedex.ToString();
        }
        #endregion
    }
}
