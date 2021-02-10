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
            Console.WriteLine(Show.initial);
            Console.WriteLine(Text);
        }    
    }
}

/*

public string name
{
    get  {return name};
    set  { name = value};
}

*/
