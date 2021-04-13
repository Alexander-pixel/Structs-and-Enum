using System;

namespace Practical
{
    public struct Client
    {
        private string _clientCode;
        private string _name;
        private string _surname;
        private string _address;
        private string _number;
        private int _ordersQuantity;
        private Request[] _requests;

        public void AddArticle(Request obj)
        {
            if (_requests == null)
                _requests = new Request[1];
            else
                Array.Resize(ref _requests, _requests.Length + 1);
            
            _requests[_requests.Length - 1] = obj;
        }

        public void DeleteArticle(Request obj)
        {
            int pos = 0;
            for (int i = 0; i < _requests.Length; i++)
            {
                if (_requests[i].Client.Name == obj.Client.Name)
                    pos = i;
            }
            Array.Clear(_requests, pos, 1);
        }

        public Request this[int index]
        {
            get => _requests[index];
            set => _requests[index] = value;
        }

        public string ClientCode
        {
            get => _clientCode;
            set => _clientCode = value;
        }
        
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        
        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }
        
        public string Address
        {
            get => _address;
            set => _address = value;
        }
        
        public string Number
        {
            get => _number;
            set => _number = value;
        }
        
        public int OrdersQuality
        {
            get => _ordersQuantity;
            set => _ordersQuantity = value;
        }
        
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < _requests.Length; i++)
                {
                    sum += _requests[i].Sum;
                }

                return sum;
            }
        }

        public Client(string clientCode, string name, string surname, string address, 
            string number, int ordersQuantity)
        {
            _clientCode = clientCode;
            _name = name;
            _surname = surname;
            _address = address;
            _number = number;
            _ordersQuantity = ordersQuantity;
            _requests = null;
        }
        
    }
}