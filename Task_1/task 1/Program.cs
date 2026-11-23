using System.Reflection.Metadata;
using CheackingTheInputs;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member member = new Member();
            TakingAndCheckingId inputId = new TakingAndCheckingId();
            TakingAndCheckingName inputName = new TakingAndCheckingName();
            TakingAndCheckingAge inputAge = new TakingAndCheckingAge();
            TakingAndCheckingGender inputGender = new TakingAndCheckingGender();
            TakingAndCheckingMembership inputMembership = new TakingAndCheckingMembership();

            member.id = inputId.CheckId();
            MakeSpace();

            member.name = inputName.checkName();
            MakeSpace();

            member.age = inputAge.CheckAge();
            MakeSpace();

            int valueOfGender= inputGender.CheckGender();
            member.gender = (MemberGender)valueOfGender;
            MakeSpace();

            int valueOfMembership = inputMembership.CheckMembership();
            member.MembershipPrice = valueOfMembership;
            member.MembershipType= (Membership)valueOfMembership;
            MakeSpace();

            Console.WriteLine("===========Member Data===========");
            PrintData(member.id, member.name, member.age, member.gender, member.MembershipType);

            Console.ReadKey();







        }
        public static void MakeSpace()
        {
            Console.WriteLine("------------------------------------------------------------");

        }
        public static void PrintData(int id,string name,int age,MemberGender gender,Membership membership)
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Membership: " + membership);
            Console.WriteLine("Membership Price: " + (int)membership);
        }


    }
    
}
