using System;
using System.Collections.Generic;
using Demo.Models;
using Demo.Pages;
using EasyConsole;

namespace Demo.Providers
{
    public class MenuProvider : IMenuItemProvider
    {
        private int _counter = 0;
        private List<Option> _options = new List<Option>();
        private readonly Program _program;
        private readonly List<Person> _persons = new List<Person>();

        public MenuProvider(Program program)
        {
            _program = program;

            _persons.Add(new Person {Name = "Mikko", Age = 26});
            _persons.Add(new Person {Name = "Aino", Age = 24});
            _persons.Add(new Person {Name = "Eeva", Age = 27});
        }
        
        public Option[] GetMenuItems()
        {
            _counter++;
            _options.Add(
                new Option($"Page {_counter.ToString()}", () => _program.NavigateTo<Page1Ai>())    
            );

            return _options.ToArray();
        }
    }
}