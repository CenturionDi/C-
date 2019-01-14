using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News3
{
    class Program
    {
        private static void DrawMenu(int maxitems)
        {

            Console.WriteLine(" 1. Login");
            Console.WriteLine(" 2. Register");
            Console.WriteLine(" 3. Exit program");
            Console.WriteLine("Make your choice: type 1, 2,... or {0} for exit", maxitems);

        }
        private static void DrawMenu2(int maxitems2)
        {

            Console.WriteLine(" 1. Create");
            Console.WriteLine(" 2. Show");
            Console.WriteLine(" 3. Comment");
            Console.WriteLine(" 4. Exit program");
            Console.WriteLine("Make your choice: type 1, 2,... or {0} for exit", maxitems2);

        }
        static void Main(string[] args)
        {

            const int maxMenuItems = 3;
            int selector = 0;
            bool good = false;
            List<User> users;
            List<Article> articles;
            List<Comment> comments;
            while (selector != maxMenuItems)
            {
                Console.Clear();

                DrawMenu(maxMenuItems);
                good = int.TryParse(Console.ReadLine(), out selector);
                if (good)
                {
                    switch (selector)
                    {
                        case 1:
                            using (var context = new ContextNews())
                            {
                                users = context.Users.ToList();
                                Console.WriteLine("Enter Login: ");
                                string tempLogin = Console.ReadLine();
                                Console.WriteLine("Enter Password: ");
                                string tempPassword = Console.ReadLine();

                                //foreach(User person in users)
                                //{

                                //    if ((person.Login == tempLogin) && (person.Password == tempPassword))
                                //    {
                                //        Console.WriteLine("hi hi");
                                //        break;
                                //    }
                                //    else
                                //    {
                                //        Console.WriteLine("Error enter valid data");
                                //        break;
                                //    }
                                //}
                                int index = 0;
                                for (int i = 0; i < users.Count; i++)
                                {
                                    if ((users[i].Login == tempLogin) && (users[i].Password == tempPassword))
                                    {

                                        index = i;
                                    }
                                }
                                if ((users[index].Login == tempLogin) && (users[index].Password == tempPassword))
                                {
                                    Console.WriteLine("hi hi");
                                    int userindex = index;
                                    const int maxMenuItems2 = 4;
                                    int selector2 = 0;
                                    bool good2 = false;
                                    while (selector2 != maxMenuItems2)
                                    {
                                        Console.Clear();

                                        DrawMenu2(maxMenuItems2);
                                        good2 = int.TryParse(Console.ReadLine(), out selector2);
                                        if (good2)
                                        {
                                            switch (selector2)
                                            {
                                                case 1:
                                                    Console.WriteLine("Enter Title: ");
                                                    Console.WriteLine("Enter Content: ");
                                                    context.Articles.Add(new Article
                                                    {
                                                        Title = Console.ReadLine(),
                                                        Content = Console.ReadLine(),
                                                        ArticleDate = DateTime.Now,
                                                        Author = users[index]

                                                    });

                                                    context.SaveChanges();
                                                    Console.ReadKey();
                                                    break;
                                                case 2:
                                                    articles = context.Articles.ToList();
                                                    comments = context.Comments.ToList();
                                                    Console.WriteLine("Articles:");
                                                    for (int i = 0; i < articles.Count; i++)
                                                    {
                                                        Console.Write("ID:");
                                                        Console.WriteLine(articles[i].Id);
                                                        Console.Write("Title:");
                                                        Console.WriteLine(articles[i].Title);
                                                        Console.Write("Content:");
                                                        Console.WriteLine(articles[i].Content);
                                                        Console.Write("Date:");
                                                        Console.WriteLine(articles[i].ArticleDate);
                                                        Console.Write("Author:");
                                                        Console.WriteLine(articles[i].Author.Login);
                                                        Console.WriteLine("Comments:");
                                                        int x = 0;
                                                        for (int j = 0; j < comments.Count; j++)
                                                        {
                                                            if (comments[j].Post == articles[i])
                                                            {
                                                                Console.Write("ID:");
                                                                Console.WriteLine(comments[j].Id);
                                                                Console.Write("Content:");
                                                                Console.WriteLine(comments[j].Content);
                                                                Console.Write("date:");
                                                                Console.WriteLine(comments[j].CommentDate);
                                                                Console.Write("Author:");
                                                                Console.WriteLine(comments[j].Author.Login);
                                                            }


                                                        }
                                                    }
                                                    //Console.WriteLine("Comments:");
                                                    //int x =0;
                                                    //for (int j = 0; j < comments.Count; j++)
                                                    //{
                                                    //    if (comments[j].Post[x]== articles[i])
                                                    //    {
                                                    //        Console.Write("ID:");
                                                    //        Console.WriteLine(comments[j].Id);
                                                    //        Console.Write("Content:");
                                                    //        Console.WriteLine(comments[j].Content);
                                                    //        Console.Write("date:");
                                                    //        Console.WriteLine(comments[j].CommentDate);
                                                    //        Console.Write("Author:");
                                                    //        Console.WriteLine(comments[j].Author.Login);
                                                    //    }


                                                    //}
                                                    Console.WriteLine("______________________________________");
                                                    Console.ReadKey();
                                                    break;
                                                case 3:
                                                    int tempId = 0;
                                                   
                                                    Console.WriteLine("Enter post Id: ");
                                                    tempId = Convert.ToInt32(Console.ReadLine());

                                                    articles = context.Articles.ToList();
                                                   

                                                    Console.WriteLine("Enter Content: ");
                                                    context.Comments.Add(new Comment
                                                    {

                                                        Content = Console.ReadLine(),
                                                        CommentDate = DateTime.Now,
                                                        Author = users[index],
                                                        Post = articles[tempId]

                                                    });

                                                    context.SaveChanges();
                                                    Console.ReadKey();
                                                    break;

                                                default:

                                                    break;
                                            }
                                        }

                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Error");
                                }
                            }
                            Console.ReadKey();
                            break;
                        case 2:

                            using (var context = new ContextNews())
                            {
                                Console.WriteLine("Enter Name: ");
                                Console.WriteLine("Enter Surname: ");
                                Console.WriteLine("Enter Login: ");
                                Console.WriteLine("Enter Password: ");
                                context.Users.Add(new User
                                {
                                    Name = Console.ReadLine(),
                                    Surname = Console.ReadLine(),
                                    Login = Console.ReadLine(),
                                    Password = Console.ReadLine()

                                });

                                context.SaveChanges();
                            }
                            Console.ReadKey();
                            break;


                        default:

                            break;
                    }
                }

                Console.ReadKey();
            }





            //using (var context = new ContextNews())
            //{
            //    var result = context.Users.ToList();
            //    context.Users.Add(new User
            //    {
            //        Name = "John",
            //        Surname = "Clarkson",
            //        Login = "Black",
            //        Password = "qwerty"

            //    });

            //    context.SaveChanges();
            //}

        }
    }
}
