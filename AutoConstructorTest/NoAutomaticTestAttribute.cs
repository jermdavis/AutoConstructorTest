using System;

namespace AutoConstructorTest
{

    [AttributeUsage(AttributeTargets.Class)]
    public class NoAutomaticTestAttribute : Attribute
    {

    }

}