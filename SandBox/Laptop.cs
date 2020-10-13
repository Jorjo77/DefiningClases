using System;
using System.Collections.Generic;
using System.Text;

namespace SandBox
{
    public class Laptop
    {
        //не е хубажо да пишем инер класове
        //private string name; In Java
        private string name;
        public Laptop(string name)//в конструктора ще създаваме нещо - подаваме каквото е нужно и той разпределя работата - записва стойностите на нашите пропъртита.
           //В програмирането е важно да разберем концепцията (логиката), нея знаем ли стъпка по стъпка ще я разпишем. 
        {
            this.Name = name;
        }

        public string Name 
        { 
            get
            {
                return name;//при гетване и сетване много да внимаваме да не напишем тук Name т.е. с голяма вместо малка буква, защото така ще направим безкраен цикъл и ще даде грешка: StackOverflow!!!
            } 
            set
            {
                name = value;
            }
        }

        public void Print()
        {
            Console.WriteLine(this.Name);
        }
        //In C# отдолу си прави филд и си го гетва и си го сетва!

        ////In Java
        //public void SetName(string name)
        //{
        //    this.name = name;
        //}

        //public string GetName()
        //{
        //    return this.name;
        //}
    }
}
