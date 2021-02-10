using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string postText = Console.ReadLine();

            Post post = new Post();
            post.Text = postText;
            post.ShowPost();

        }
    }

    class Post //don't forget constructors namand class name must be same.
    {
        string text;
        string initial;  //created a field
        public Post() //then gived initial value
        {
            initial = "New post";
        }

        public string Text
        {
            get  { return text;}
            set  { text = value;}
        }

        public void ShowPost()// outputs  content!
        {
            Post Show = new Post();//for  calling constructor.
            Console.WriteLine(Show.Post);
            Console.WriteLine(Text);
        }
        
        
        //write a property for member text
        
    }
}

/*
./Playground/file0.cs(24,13): error CS0103: The name 'post' does not exist in the current context
./Playground/file0.cs(22,23): error CS0161: 'Post.poster()': not all code paths return a value
./Playground/file0.cs(35,31): error CS1503: Argument 1: cannot convert from 'method group' to 'bool'
./Playground/file0.cs(36,31): error CS0103: The name 'postText' does not exist in the current context

public string name
{
    get  {return name};
    set  { name = value};
}

*/
