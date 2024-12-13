using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependency_injection
{
    class User
    {
        public string userName;
        public int userAge;

        public User(string userName , int userAge)
        {
            this.userName = userName;
            this.userAge = userAge;
        }
    }

    class Post
    {
        public string postTitle;
        public string postMessage;

        public User user;
        public Post()
        {
            
        }
        public void setUser(User user)
        {
            this.user = user;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
        User user = new User("Ahmed", 25);

        Post post = new Post(); 
        post.setUser(user);
       
        post.postTitle = "First Code";
        post.postMessage = "Console.writeLine(Hello world)";

       
        Console.WriteLine("Post Title : " + post.postTitle);
        Console.WriteLine("Post Message : " + post.postMessage);
        Console.WriteLine("Posted by " + user.userName + " Age " + user.userAge);
        }
    }
}
