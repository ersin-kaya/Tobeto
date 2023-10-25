using System;
namespace Classes
{
    public class Customer
    {
        //field tanımlamak
        //public string FirstName; //getter ve setter kullanılmaz

        //property tanımlamak
        public int Id { get; set; }

        //FirstName için: burada firstName için bir field tanımlıyoruz ve...
        private string _firstName; //field
        //buradaki property içerisinde o field'ı kullanıyoruz
        public string FirstName
        {
            get
            {
                return "Mrs." + _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        //buna implementasyon detayının gizlenmesi deniyor, o da encapsulation dediğimiz tekniktir...
        //fakat bunu genellikle böyle yapmayız, eski tip yazılımlarda sıklıkla görülür,
        //single-responsibility prensibine aykırı işlemler yapılır,
        //bunun yerine auto property kullanırız ( public int Id { get; set; } )
        //eğer ileride bir değişikliğe ihtiyaç olursa get ve set için bloklar açılarak düzenlenebilir

        public string LastName { get; set; }
        public string City { get; set; }
    }
}

