/*
Design a class called Post. This class models a StackOverflow post. 
It should have properties for title, description and the date/time 
it was created. We should be able to up-vote or down-vote a post.
We should also be able to see the current vote value. 
In the main method, create a post, up-vote and down-vote it a few
times and then display the current vote value.

In this exercise, you will learn that a StackOverflow post should 
provide methods for up-voting and down-voting. You should not give 
the ability to set the Vote property from the outside, because 
otherwise, you may accidentally change the votes of a class to 0 
or to a random number. And this is how we create bugs in our programs. 
The class should always protect its state and hide its implementation detail.

Educational tip: The aim of this exercise is to help you understand 
that classes should encapsulate data AND behaviour around that data. 
Many developers (even those with years of experience) tend to create 
classes that are purely data containers, and other classes that are 
purely behaviour (methods) providers. This is not object-oriented 
programming. This is procedural programming. Such programs are very 
fragile. Making a change breaks many parts of the code. 
 */

namespace StackOverflowPost
{
    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _createdDate;
        private int _votes;

        public string Title { get => _title; set => _title = value; }
        public string Description { get => _description; set => _description = value; }
        public DateTime CreatedDate { get => _createdDate; set => _createdDate = value; }
        public int Votes { get => _votes; set => _votes = value; }

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.CreatedDate = DateTime.Now;
            this.Votes = 0;
        }

        public void voteUp()
        {
            Votes++;
        }

        public void voteDown()
        {
            Votes--;
        }

        public int numVotes()
        {
            return Votes;
        }
    }
}