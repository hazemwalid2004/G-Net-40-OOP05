namespace assOOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            #region Q1_Part1
            // What is an interface in C#?
            //it's a contract
            //Why do we use interfaces instead of depending on concrete classes directly?
            //because it's make a loose couplaing and easy to test 
            //Mention at least three benefits of using interfaces.
            //loose coupling , use polymorphism without inhertance and we can use multiple interface
            #endregion
            #region Q2_part1
            //a) What is the problem with this design? Both interfaces have a method called Greet() — how does the class handle it currently?
            //method name conflict / when we call method with both interface print the same thing 
            //b) How would you fix this so IEnglishSpeaker.Greet() says "Hello" and IArabicSpeaker.Greet() says "Ahlan"? What is this technique called?
            // we use explicit interface 
            //c) After applying your fix, can you call Greet() directly on a Translator object (e.g. translator.Greet())? Why or why not? How do you call each version?
            //no / becouse  explicit members are hidden from the class // use interface as a variable type then call
            #endregion
            #region Q3_Part1
            //Explain the difference between a shallow copy and a deep copy.
            //shallow copy object  value type copied independtily but referance type shared 
            //deep copy copy object  value type copied independtily but referance type independtily 
            //When would you use each one?
            //shallow -> object is immutable, no nested reference , performance is critical
            //deep ->objects must be isolated, modifications should not affect original
            //What is the risk of using a shallow copy when the object has reference-type fields?
            //the objects share the inner referance so any change in referance change the two objects 
            #endregion
        }
    }
}
