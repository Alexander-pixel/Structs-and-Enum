using System;

namespace Practical
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Article article = new Article() {Name = "Article", Code = "1234", Price = 25};
            Client client = new Client() {Name = "Alex", Surname = "Tkachenko", Address = "Address", Number = "Number"};
            RequestItem requestItem = new RequestItem() {Article = article, Quantity = 4};
            Request request = new Request() {Client = client, Date = "12 November", OrderCode = "1234"};
            request.AddArticle(requestItem);
            Console.WriteLine(request.Sum);
            Article article1 = new Article() {Name = "Coca-Cola", Code = "1234", Price = 30};
            request.AddArticle(new RequestItem(article1, 12));
            request.DeleteArticle(requestItem);
            Console.WriteLine(request.Sum);*/

            Shop shop = new Shop();
            Article article = new Article() {Name = "Coca-Cola", Code = "1234", Price = 30, ArticleType = (ArticleType)0};
            RequestItem requestItem = new RequestItem() {Article = article, Quantity = 4};
            Client client = new Client() {Name = "Alex", Surname = "Tkachenko", Address = "Address", Number = "Number"};
            Request request = new Request() {Client = client, Date = "12 November", OrderCode = "1234"};
            client.AddArticle(request);
            request.AddArticle(requestItem);
            shop.AddArticle(article);
            shop.AddClient(client);
            Console.WriteLine(request.Sum);
        }
    }
}