using System;

namespace EasyConsole
{
    public class DynamicPage<T> : Page
    {   
        public DynamicPage(string title, Program program) : base(title, program)
        {
        }

        public Type ParameterType()
        {
            return typeof(T);
        }
    }
}