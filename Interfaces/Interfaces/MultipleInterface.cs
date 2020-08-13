using System;

namespace Interfaces
{
    public interface IBlog
    {
        string ShowBlog();
    }
    public interface IField
    {
        string ShowField();
    }
    public class Blog : IBlog, IField
    {
        public string ShowBlog()
        {
            return "C# Fundamentals";
        }

        public string ShowField()
        {
            return "Technical Training";
        }
    }
}
