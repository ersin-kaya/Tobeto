import logo from './logo.svg';
import './App.css';
import React, { useEffect, useState } from 'react';
import { clear } from '@testing-library/user-event/dist/clear';
import { act } from 'react-dom/test-utils';

// JSX => HTML + JS
// class yazınca html'deki mi yoksa js'tekini mi kastediyoruz? bu gibi çakışmalar yaşanmaması için html'deki keyword'lerin ismi değiştirilmiş
// class => className
export default function App() {

  // let count = 0;
  // let i;

  // react hooks
  // useState // react'ın o an içinde bulunduğumuz component'in durumunu yöneten bir yapısı, arkada bir state var siz onu değiştirdikçe UI güncelleniyor
  // total, setTotal => // total ve setTotal'ı getter ve setter gibi düşünebiliriz  // initial value // get react tarafında çok fazla kullanılmaz
  // let total = 0;
  const [total, setTotal] = useState(0); // buradaki tanım değişmeyeceği için const dedik yoksa total değeri değişecek 
  // js: let count = 0;
  // react: const [total, setTotal] = useState(0); // useState(); diyebiliriz

  // hook'lar genelde use ile başlar, use gördük mü orada bir react hook'u olduğuna dair...

  // useEffect 
  // dependency listesindeki veriler değiştiği anda tetiklenen yapıdır // aşağıda dependency listesine total'i veriyoruz ki total her değiştiğinde, useEffect içerisine verdiğimiz fonksiyon çalışsın
  // useEffect component ilk render edildiğinde de çalışır örn. sayfa açıldığında ardından dependency listesine bakılır
  useEffect(
    () => {
      if (total > 10) {
        // console.log(`useEffect çalıştı: ${total}`)
        alert("Toplam 10'dan büyük olamaz");
        setTotal(10); // async old. unutma! hemen alt satırdaki log önce çalışıyor
        console.log(`useEffect çalıştı: ${total}`)
        // !!!! dependency listesinde bulunan bir değeri useEffect'in içerisinde değiştiriyorsanız sonsuz döngüye gireriz // örn. useEffect sayfa render edilince çalışacak, ardından gidip set edecek, set edince useEffect tekrar çalışacak çünkü bağımlılık listesinde total var, böylece..
        // bunu engellemek için react'in içerisinde zaten bir mekanizma var react recursive yapıyı anlayıp döngüyü kırıyor... ancak bizim yinede bu noktaya dikkat etmemiz gerekiyor. // bu aslında bir code smell!
      }
      console.log(`useEffect çalıştı: ${total}`)
    }, [total]);

  // useState'teki asenkronluk durumunu useEffect ile ele almak önemli! Yoksa hatalı sonuç alabiliriz..

  // useEffect() // bir sayfada birden fazla useEffect kullanılabilir..
  useEffect(
    () => {
      console.log("useEffect2"); // useEffect2 sadece sayfa yüklendiğinde çalışır çünkü dependency listesi boş // bununda yaygın kullanımına örnek verecek olursak: backend'den gelen bir ürün listesi var, bu ürünleri sayfa açıldığı zaman çekmek isteriz...
    }, []
  );

  const increase = () => {
    setTotal(total + 1); // async
    // async old. için bir fazlası yazmıyor
    // async fonksiyonlar kodun execution sırasını bloke etmeyen fire-and-forget dediğimiz yapılardır, dolayısıyla setTotal işlemi yapana kadar console.log(total) çalışıyor zaten o yüzden eski hali yazıyor
    // useState'teki asenkronluk durumunu useEffect ile ele almak önemli! Yoksa hatalı sonuç alabiliriz..

    // 1 artmış toplamı konsola yazalım
    // console.log(total); 
  }

  const decrease = () => {
    setTotal(total - 1);

    // 1 azalmış toplamı konsola yazalım
    // console.log(total); // async old. için bir eksiği yazmıyor
  }

  // Two Way Data Binding
  // input değiştiğinde değişkeni, değişken değiştiğinde input'u değiştirmektir diyebiliriz
  const [activity, setActivity] = useState("");
  const [activityList, setActivityList] = useState(["Aktivite 1", "Aktivite 2", "Aktivite 3"])

  const clearActivity = () => {
    setActivity("");
  }

  // array'lerde silme işlemini genelde filtreleyerek yaparız 
  const removeActivity = (activity) => {
    setActivityList(activityList.filter(i => i !== activity));
  }

  const addActivity = () => {
    // yöntemlerden biris bu ancak diğeri daha doğru
    // setActivityList((prevState) => {
    //   // console.log(prevState);
    //   prevState.push(activity);
    //   // console.log(prevState);
    //   return prevState;
    // })

    //
    setActivityList([...activityList, activity]); // !!!!! çok kullanılır, state yönetiminde karşımıza çok çıkar
    clearActivity();
  }

  return ( // return tarafı JSX
    <React.Fragment>
      <div>
        <p>{total}</p>
        {/* <p>{1 + 1}</p> */}
      </div>
      <div>
        <button onClick={increase}>Artır</button> {/* burada increase metodunun referansını veriyoruz o yüzden () yok ancak sık kullanılan bu değildir */}
        {/* <button onClick={decrease}>Azalt</button> */}
        <button onClick={() => { decrease(); /*console.log("test")*/ }}>Azalt</button> {/* anonim bir fonk. içerisinde başka bir fonk. çağırabiliriz */}
        {/* 
          <button onClick={decrease()}}>Azalt</button> 
          !!! referans gibi geçerken, fonksiyonu normal bir şekilde -devrease()- çağırırsanız infinite loop'a düşersiniz..
          referans almanız gerekirken direkt fonk. çağırıyorsuz, fonk. çalışıyor geriye bir ref. dönmüyor ve tekrar tekrar çalışıyor, bu hatalı..
          ya direk referansı vereceksiniz: onClick={increase}
          ya da bir fonksiyonun içerisinde bunu çağıracaksınız: onClick={() => { decrease(); }} 

          !!! referans vermenin eksisi ise parametreleri geçemememiz... dolayısıyla çok fazla kullanılmaz
        */}

      </div>

      <br />
      <hr />
      <br />

      <div>

        <input value={activity} onChange={(event) => { setActivity(event.target.value) }} type="text" placeholder='Aktivite giriniz...' />

        <br />

        <button onClick={() => { addActivity() }}>Ekle</button>
        <ul>
          {/* JSX içerisinde iterasyonlar her zaman MAP ile yapılmalıdır */}
          {activityList.map((element) => <li key={element}>{element} <button onClick={() => { removeActivity(element) }}>X</button></li>)}
          {/* hemen yukarıda key'değerine element vermek doğru değil, hepsinin benzersiz olması lazım yoksa aynı veriyi girince yine hata veriyor... araştırılacak... */}
        </ul>
      </div>
    </React.Fragment >
  );
}

// export default App; // yerine function'ın önüne export default yazabiliriz

// export const variable1 = 1; // yalnızca birisi default olarak export edilebilir
