using System;

namespace Practical
{
    public struct Article
    {
        private string _name;
        private string _code;
        private int _price;
        private ArticleType _articleType;

        public ArticleType ArticleType
        {
            get => _articleType;
            set => _articleType = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        
        public string Code
        {
            get => _code;
            set => _code = value;
        }
        
        public int Price
        {
            get => _price;
            set => _price = value;
        }

        public Article(string name, string code, int price, ArticleType articleType)
        {
            _name = name;
            _code = code;
            _price = price;
            _articleType = articleType;
        }
        
    }
}