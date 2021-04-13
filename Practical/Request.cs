using System;

namespace Practical
{
    public struct Request
    {
        private string _orderCode;
        private Client _client;
        private string _date;
        private RequestItem[] _requestItems;

        public Request(string orderCode, Client client, string date)
        {
            _orderCode = orderCode;
            _client = client;
            _date = date;
            _requestItems = null;
        }

        public void AddArticle(RequestItem obj)
        {
            if (_requestItems == null)
                _requestItems = new RequestItem[1];
            else
                Array.Resize(ref _requestItems, _requestItems.Length + 1);

            _requestItems[_requestItems.Length - 1] = obj;
        }

        public void DeleteArticle(RequestItem obj)
        {
            int pos = 0;
            for (int i = 0; i < _requestItems.Length; i++)
            {
                if (_requestItems[i].Article.Name == obj.Article.Name)
                    pos = i;
            }
            Array.Clear(_requestItems, pos, 1);
        }
        public string OrderCode
        {
            get => _orderCode;
            set => _orderCode = value;
        }
        
        public Client Client
        {
            get => _client;
            set => _client = value;
        }
        
        public string Date
        {
            get => _date;
            set => _date = value;
        }

        public RequestItem this[int index]
        {
            get => _requestItems[index];
            set => _requestItems[index] = value;
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < _requestItems.Length; i++)
                {
                    sum += _requestItems[i].Sum;
                }
                return sum;
            }
        }
    }
}