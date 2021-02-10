using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Sample input - any string
Output
Newpost
String
*/
namespace Sololearn
{
  // Create a Post class
  class Post
  {
    string model;  // Create a field

    // Create a class constructor for the Post class
    private Post()
    {
      model = "New post"; // Set the initial value for model
    }

    static void Main(string[] args)
    {
        string str;
    str= Console.ReadLine();
      Post Show= new Post();  // Create an object of the Post Class (this will call the constructor)
      Console.WriteLine(Show.model);  // Print the value of model
      Console.Write("{0}\n", str);
    }
  }
}
