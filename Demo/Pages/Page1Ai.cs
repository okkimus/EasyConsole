using EasyConsole;
using Demo.Models;

namespace Demo.Pages
{
    class Page1Ai : DynamicPage<Person>
    {
        private readonly Person _person;
        
        public Page1Ai(Program program, Person person)
            : base("Person", program)
        {
            _person = person;
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("Hello from Person page");
            Output.WriteLine($"This person is called {_person.Name}.");
            Output.WriteLine($"He is {_person.Name} years old.");

            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }
    }
}
