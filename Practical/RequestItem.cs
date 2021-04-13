namespace Practical
{
    public struct RequestItem
    {
        private Article _article;
        private int _quantity;

        public int Sum
        {
            get => Quantity * _article.Price;
        }

        public RequestItem(Article article, int quantity)
        {
            _article = article;
            _quantity = quantity;
        }

        public Article Article
        {
            get => _article;
            set => _article = value;
        }
        
        public int Quantity
        {
            get => _quantity;
            set => _quantity = value;
        }
    }
}