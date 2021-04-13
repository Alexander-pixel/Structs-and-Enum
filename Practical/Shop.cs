using System;

namespace Practical
{
    public class Shop
    {
        private Client[] _clients;
        private Article[] _articles;

        public Shop()
        {
            _clients = null;
            _articles = null;
        }

        public void AddClient(Client obj)
        {
            if (_clients == null)
                _clients = new Client[1];
            else
                Array.Resize(ref _clients, _clients.Length + 1);

            _clients[_clients.Length - 1] = obj;
        }
        
        public void DeleteClient(Client obj)
        {
            int pos = 0;
            for (int i = 0; i < _clients.Length; i++)
            {
                if (_clients[i].Name == obj.Name)
                    pos = i;
            }
            Array.Clear(_clients, pos, 1);
        }
        
        public void AddArticle(Article obj)
        {
            if (_articles == null)
                _articles = new Article[1];
            else
                Array.Resize(ref _articles, _articles.Length + 1);

            _articles[_articles.Length - 1] = obj;
        }

        public void DeleteArticle(Article obj)
        {
            int pos = 0;
            for (int i = 0; i < _articles.Length; i++)
            {
                if (_articles[i].Name == obj.Name)
                    pos = i;
            }
            Array.Clear(_articles, pos, 1);
        }

        public int GetOrderSum(Request obj)
        {
            return obj.Sum;
        }
        
    }
}