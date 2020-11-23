using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Fonctions_Agregation
{
    class Client
    {
        int _id;
        string _nom;
        public int id { get { return _id; }  set { _id = value; } }
        public string nom { get { return _nom; } set { _nom = value; } }
        public Client(int id, string nom)
        {
            _id = id;
            _nom = nom;
        }
    }
}
