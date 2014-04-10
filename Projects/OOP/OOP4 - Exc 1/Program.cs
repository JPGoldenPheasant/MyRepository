using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4___Exc_4
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

#region 4.1
interface IFlyver
{
    string Flyv();
}
interface IFlyder
{
    string Flyd();
}
interface IDykker
{
    string Dyk();
}
#endregion
#region 4.2
abstract class FlyveMaskine : IFlyver//, IVægtAfgiftsObjekt
    {
        public double MaxHøjde { get; set; }
        public double Hastighed { get; set; }
       // public Brændstof Brændstof { get; set; }
        public double Vægt { get; set; }
        
        public abstract string Flyv();

       /* decimal IVægtAfgiftsObjekt.Afgift
        {
            get { return AfgiftsBeregner.BeregnVægtAfgift(this); }
        }*/
    }
class Fastvinge : FlyveMaskine
{
    public override string Flyv()
    {
        return "Fastvinge flyv!";
    }
}
class Helicopter : FlyveMaskine
{
    public override string Flyv()
    {
        return "Helikopeter flyv!";
    }
}

class VarmluftsBallon : FlyveMaskine
{
    public override string Flyv()
    {
        return "Jeg har for mange penge -  flyv!";
    }
}
class Vandflyver : Fastvinge, IFlyder
{
    public string Flyd()
    {
        return "vandflyver flyd";
    }
}
#endregion
#region 4.3
class MarineFartøj : IFlyder
{
    public double Længde { get; set; }
    public double Bredde { get; set; }
    public virtual string Flyd()
    {
        return "Marinefartøjer kan flyde";
    }
}
class Jolle : MarineFartøj
{
    public override string Flyd()
    {
        return base.Flyd() + " selv joller!";
    }
}
class Ubåd : MarineFartøj, IDykker
{
    public string Dyk()
    {
       return "Ubåde kan dykke";
    }
}
#endregion
#region 4.4
public abstract class Fugl : IFlyver
{
    public double Næblængde { get; set; }
    public double ÆgStørrelse { get; set; }

}
class Albatros : Fugl, IFlyder, IFlyver
{
    private IFlyver _flyver;

    //constructor injection
    public Albatros(IFlyver flyver)
    {
        _flyver = flyver;
    }

    public string Flyv()
    {
        return _flyver.Flyv();
    }

    public string Flyd()
    {
        return "Albatros flydning";
    }
}

class Kolibri : Fugl, IFlyver
{
    //property injection
    public IFlyver Flyver { get; set; }

    public string Flyv()
    {
        if (this.Flyver == null)
        {
            return "Jeg kan ikke flyve, da jeg ikke har nogen til at flyve for mig";
        }
        else
        {
            return this.Flyver.Flyv();
        }
    }
}

class Pingvin : Fugl, IDykker
{
    public string Dyk()
    {
        return "Pingvin Dyk";
    }

    public string Flyd()
    {
        return "Pingvin flyder";
    }
}

class And : Fugl, IFlyver, IFlyder, IDykker
{
    private IFlyver _flyver = new FællesFugleFlyvning();

    public string Flyv()
    {
        return _flyver.Flyv();
    }

    public string Flyd()
    {
        return "Anden flyder";
    }

    public string Dyk()
    {
        return "Anden dykker";
    }
}

//4.5
public class FællesFugleFlyvning : IFlyver
{
    public string Flyv()
    {
        return "Fælles fugle-flyvning";
    }
}
class Kolibri : Fugl
{

}
class Pingvin : Fugl
{

}
class And : Fugl
{

}
#endregion