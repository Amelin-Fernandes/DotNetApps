using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLib
{
    public class Polymorphism : Talents
    {
        public virtual string Settle() {
            return "Get a government job, retire by 60 yrs and settle in native";
        }

        public string GetMarried()
        {
            return "Register marriage, surprise parents and settle abroad";
        }

        public override string Drawing()
        {
            return "Drawing potraits, Tanjore Paintings";
        }
        public override string WhatIsDating()
        {
            return "Meeting special friend at restaurant";
        }
    }

    //abstract = incomplete, c# doesn't support multiple inheritance
    public abstract class Talents
    { //because I don't know what to draw and whom to date we use abstract
        public abstract string WhatIsDating();
        public abstract string Drawing();

        public string GetDetails()
        {
            return "Drawing and Dating are talents";
        }
    }

    public class Child : Polymorphism
    {
        public override string Drawing()
        {
            return "Drawing Abstarct art, Mandala Art";
        }
        public override string WhatIsDating()
        {
            return "Use Tinder App";
        }
        public override string Settle()
        {
            string howToLive = "Get a fat salaried job in fortune 500 company, visit different countries, live outside hometown";
            howToLive = $"{howToLive} and later follow this: {base.Settle()}";
            return howToLive;
        }

        new public string GetMarried()
        {
            return "Register marriage, surprise parents and settle abroad";
        }
    }
 

}
