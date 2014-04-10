using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise_2
{
    #region InheritanceAndPolymorph
    abstract class Pet
    {
        public string Name { get; set; }
        public virtual string Walk()
        {
            return "Swoosh Swoosh";
        }
        public abstract string Talk(); /*No implementation here*/
    }
    #region Cat
    abstract class Cat : Pet
    {
        protected int _miawFactor; //Instansvariable: _variableNavn
        public virtual int MiawFactor
        {
            get { return _miawFactor;  }
            set
            {
                if ((value >= 1) && (value <= 10)) _miawFactor = value;
                else throw new ArgumentOutOfRangeException("Incomprehensible miaw factor!");
            }
        }
        public override string Walk()
        {
            return "Sneaky sneaky" + base.Walk();
        }
    }
    class NorwegianForestCat : Cat
    {
        public override string Talk()
        {
            return "*SILENCE*";
        }
    }
    class SacreBirma : Cat
    {
        public override string Talk()
        {
            return "If I fits, I sits!";
        }
        public override int MiawFactor
        {
            get
            {
                return base.MiawFactor;
            }
            set
            {
                //Allowed to be extra cute
                if (value > 10 && value <= 12)
                    _miawFactor = value;
                else
                    base.MiawFactor = value;
            }
        }
    }
    #endregion
    #region Dog
    abstract class Dog : Pet
    {
        public override string Talk()
        {
            return "Woof woof";
            throw new NotImplementedException();
        }
    }
    class SuchDoge : Dog
    {
        public override string Talk()
        {
            return "Such doge, much woof. Very wow.";
        }
        public override string Walk()
        {
            return "Very walk, so excercise";
        }
    }
    class GermanShepherd : Dog
    {
        public sealed override string Talk()
        {
            return base.Talk() + " and no more";
        }
    }
    class Terrier : Dog { }
    #endregion
    #endregion
    class Person
    {
        public enum Sex { Male, Female };
        private static int NEXT_ID = 1;

        #region Instance-variables
        private string _name;
        public readonly DateTime Birthday;
        private double _weight;
        private double _height = 1.20; //Default height
        private Sex _gender;
        private Person _partner;
        private List<Pet> _pets = new List<Pet>();

        #endregion

        #region Constructors

        /*Constructor*/
        public Person(string name, DateTime birthday)
            : this(name, birthday, Sex.Female) //Chaining
        {
        }
        public Person(string name, DateTime birthday, Sex gender)
            : this(name, birthday, gender, 1.50, 75, null)
        {
        }
        public Person(string name, DateTime birthday, Sex gender, double height, double weight, Person partner)
        {
            this.Name = name;
            this.Birthday = birthday;
            this.Gender = gender;
            this.Height = height;
            this.Weight = weight;
            this.Partner = partner;
            this.Id = NEXT_ID++;
        }
        #endregion

        #region Properties
        /*Properties*/
        public string Name
        {
            get { return _name; }
            set { if (!string.IsNullOrEmpty(value)) _name = value; }

        }

        public Sex Gender
        {
            get { return _gender; }
            private set { _gender = value; } //Private set: form of readonly
        }

        public double Weight
        {
            get { return _weight; }
            set
            {
                if ((value >= 0) && (value <= 300)) _weight = value;
                else throw new ArgumentOutOfRangeException("Too obese to compute!");
            }

        }
        public double Height
        {
            get { return _height; }
            set
            {
                if ((value >= 1.20) && (value <= 3)) _height = value;
                else if (value < 1.20) _height = 1.20;
                else _height = 3;
            }

        }
        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int yearsOfAge = now.Subtract(Birthday).Days;
                return (int)(yearsOfAge / 365);
            }

        }
        internal bool Married { get; set; }
        public int Id { get; private set; }
        #endregion

        //Instance method
        public double Bmi()
        {
            return Math.Round(_weight / Math.Pow(_height, 2));
        }
        //Class methods

        #region ClassMethod

        public static string Title(Person p)
        {
            string prefix;
            if (p._gender == Sex.Male)
            {
                prefix = "Mr. ";
            }
            else if (p.Married)
            {
                prefix = "Mrs. ";
            }
            else prefix = "Ms. ";
            return prefix + p._name;
        }

        #endregion

        #region Relations
        bool _updatingPartner;
        public override string ToString() //OVERIDE OBJECT PRINT METHOD ToString
        {
            bool gen = (Gender == Person.Sex.Male);
            return string.Format("{0} is a {1}-year-old {2} with a  BMI of {3} and {4}", 
                Person.Title(this),
                Age, 
                gen ? "man" : "woman",
                Bmi(),
                Partner == null ? "is single" : (!gen ? "the wife of " : "the husband of ") + Partner.Name);
        }

        public Person Partner // BINARY ASSOCATION!
        {
            get { return _partner; }
            set
            {
                //Avoid infinite call stack
                if (_updatingPartner || value == _partner)
                {
                    return;
                }

                _updatingPartner = true;//Update                               
                //Cap older association:
                Person oldPartner = _partner;
                if (oldPartner != null)
                    oldPartner.Partner = null;

                //New association:
                _partner = value;
                if (_partner != null)
                    _partner.Partner = this;

                _updatingPartner = false;  //End update 
            }
        }
        public void WalkThePets()
        {
            Console.WriteLine(Name + " is walking {0} pets: ", Gender == Sex.Male ? "his" : "her");
            foreach (Pet p in _pets)
            {
                Console.WriteLine("{0} - " + p.Walk(), p.Name);
            }
        }
        public void PetTalk()
        {
            Console.WriteLine(Name + "'s pets are talking: ");
            foreach (Pet p in _pets)
            {
                Console.WriteLine("{0} - " + p.Talk(), p.Name);
            }
        }
        public void AddPet(Pet p)
        {
            this._pets.Add(p);
        }
        public void RemovePet(Pet p)
        {
            this._pets.Remove(p);
        }

        public int NumberOfDogs()
        {
            int res = 0;
            foreach (Pet p in _pets)
            {
                if (p is Dog)
                    res++;
            }
            return res;
        }

        public double AverageMiawFactor()
        {
            int totalMiawFactor = 0;
            int numberOfCats = 0;
            Cat currentCat;
            foreach (Pet p in _pets)
            {
                currentCat = p as Cat;
                if (currentCat != null)
                {
                    numberOfCats++;
                    totalMiawFactor += currentCat.MiawFactor;
                }
            }
            return totalMiawFactor / numberOfCats;
        }
        #endregion
    }
}
