using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            string skillname;
            string check;
            Console.WriteLine("input skill name");
            skillname = Console.ReadLine();
            Skill skillName1 = new Skill(skillname);
            _91(skillname);
            check = Console.ReadLine();
            if(check == "Y")
            {

            }
            else if(check == "N")
            {
                _91(skillname);
            }
        }

        static void _91(string skillname)
        {
            if (skillname == "?")
            {

            }
            else
            {
                Console.WriteLine("Add dependency for {0}", skillname);
            }
        }

        static void _93(string skillname)
        {
            Console.WriteLine("inpu skill name");
        }
    }

    class Skill
    {
        public Skill left;
        public Skill right;
        public string SkillName;

        public Skill(string skillnameValue)
        {
            SkillName = skillnameValue;
        }
    }
}
