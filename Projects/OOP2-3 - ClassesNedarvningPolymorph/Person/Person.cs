using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Math;

class Person
{
    public enum Sex { Male, Female };
    private static int NEXT_ID = 1;

    #region Instance-variables
    private string name;
    public readonly DateTime Birthday;
    private uint weight;
    private double height = 1.20; //Default height
    private uint age;
    private Sex gender;
    private Person partner;

    #endregion
    internal bool married;

    #region Constructors

    /*Constructor*/
    public Person(string name, DateTime birthday)
        : this(name, birthday, Sex.Female) //Chaining
    {
    }
    public Person(string name, DateTime birthday, Sex gender)
    {
        this.Name = name;
        this.Birthday = birthday;
        this.Gender = gender;
        this.Id = NEXT_ID++;
    }
    #endregion

    #region Properties
    /*Properties*/
    public string Name
    {
        get { return name; }
        set { if (!string.IsNullOrEmpty(value)) name = value; }

    }

    public Sex Gender
    {
        get { return gender;}
        private set { gender = value; } //Private set: form of readonly
    }

    public uint Weight
    {
        get { return weight; }
        set
        {
            if ((value >= 0) && (value <= 300)) weight = value;
            else throw new ArgumentOutOfRangeException("Too obese to compute!");
        }

    }
    public double Height
    {
        get { return height; }
        set
        {
            if ((value >= 1.20) && (value <= 3)) height = value;
            else if (value < 1.20) height = 1.20;
            else height = 3;
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
        return weight / Math.Pow(height, 2); 
    }
    //Class methods

    #region ClassMethod

    public static string Title(Person p)
    {
        string prefix;
        if (p.gender == Sex.Male)
        {
            prefix = "Mr. ";
        }
        else if (p.Married)
        {
            prefix = "Mrs. ";
        }
        else prefix = "Ms. ";
        return prefix + p.name;
    }

    #endregion

    #region Relations

    public Person Partner
    {
        get { return partner; }
        set {
            partner = value;
            if(partner == null)
            {
                Married = false;
            }
        }
    }
    #endregion
}
