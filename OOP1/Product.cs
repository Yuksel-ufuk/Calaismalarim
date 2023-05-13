using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    // bu tür class larda sadece özelik olur
    //buranın amacaı CRUD->"C"R"U"D" Create->Eklemek Read->Okumak Update->Güncelemek Delete->Silmek
    class Product //"Entity" varlık gibi
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } //Hangi Id dahil oldugunu gösterir referans  anahtarı
        public string ProductName { get; set; }
        public double UnitPrice { get; set; } //birim fiyat
        public int UnitInStock { get; set; } //stok adeti      
    }
}
