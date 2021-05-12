using EasyConsole;

namespace Demo.Pages
{
    class Page1B : DynamicPage<double>
    {
        private readonly double _person;
        
        public Page1B(Program program, double person)
            : base("Person", program)
        {
            _person = person;
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("Hello from Page 1B");

            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }
    }
}
