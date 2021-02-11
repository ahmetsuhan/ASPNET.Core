# ASPNET.Core


## Extension Kuralları 

    1-) Class static olmalı.
    2-)Method Static olmalı.
    3-)this keywordu ilk parametre oalrak belirlenmeli
### Neden Extension ? 

    1-)Kod akışımızda ve ekip içerisinde bir bütünlük oluşturmak.
    2-)Okunabilirliği artırmak ve kod kültürünü oluşturmak.
    3-)Doğru özelliği doğru nesneye atamak.
    
### Mapper neden kullanılır? 
    Örneğin elimizde bir tane business modeli var ve sen bir database e birşeyler kaydediceksin. İşte o business modelini database e direk göndermen doğru olmuyor. Her modelinin kendi işini yapması gerekiyor. ilk modelinde atıyorum id,name,category,price,jetlag var diğer modelinde sadece id ve name var. Yani iki model birbirinden farklı, aslında ikiside aynı işi yapacaklar ama birisi businessdal üzerinde işleri alıyor işini bitiriyor ve daha sonra bunu database e işlemek adına kendi entity modelini gönderecek işte o kısımda bu mapper kullanılabilir. Business modelinden propertilerin son halini entity modeline map edip entity modelini gönderirsin. 

#### Örnek bir Extension yazımı --> <a href="https://github.com/ahmetsuhan/ASPNET.Core/tree/main/Extensions">Click Here</a>  

<hr>

## Attribute kuralları 

    1-) Yazdığın sınıfın attribute olabilmesi için Attribute den türemiş olması gerekiyor. Yani :
    
        public class MyAttribute : Attribute
        {}
    
    2-) Bizim yazdığımız Attribute nerelerde kullanılanilir onu belirtmemiz gerek: 
    
        [AttributeUsage(AttributeTarget.class |AttributeTarget.method | AttributeTarge.constructor | AttributeTarget.properties, AllowMultiple = true )]
        public class MyAttribute : Attribute
        {}
        
        yukarıdaki AllowMultiple özelliği eğer bir yerlerden inherit alınmışsa oralarda da uygulansın mı? true yaaprsak diğer alt classlarınada bu attribute ü uygular.
    
#### Örnek bir Attribute kullanımı --> <a href="https://github.com/ahmetsuhan/ASPNET.Core/tree/main/Attribute_Reflection">Click Here</a>

## ModelDto and Validations -->  <a href="https://github.com/ahmetsuhan/ASPNET.Core/tree/main/ModelDto_and_Validation">Click Here</a>

## Abstract and Interface --> <a href="https://github.com/ahmetsuhan/ASPNET.Core/tree/main/Abstract_Interface">Click Here</a>  

### Abstract class : 

    Bir class birden fazla Abstract class'tan inherit alamaz.
    Eğer bir nesne abstract bir classtan inherit almışsa, kendi constructorından önce inherit aldığı abstract classın constructorını        çağırır.
    Abstract tipler new lenemez.
    Abstract class içerisindeki virtual metod child classlarında override edilmişse Abstract classın constructorı override edilen metodları çağırır kendi virtual metodu çalışmaz. Override etmeyen child class varsa o child class Base alınan Abstract classtaki methodu çalıştırmış olur. (Sample2)
    Abstract classlarda constructor chain vardır yani birbirlerine bağlıdırlar. Sırayla çalışırlar.
#### Abstract sınıf içerisinde metot tanımlaması:
    1-) Virtual method --> methodu child sınıflarda override edebilirsin/etmeyedebilirsin. Edersen kendi methodun çalışır etmezsen Abstract class içerisindeki hali ile çalışır.
    2-) Abstract method --> Abstract class alt sınıflarda mecburen implemente edilir ve Abstract methodların bodysi olmaz.
        public abstract Test(); şeklinde tanımlanır.
    3-) Public method
    
### Interface :   
 
     Can do ilişkisi var. 
     İçerisinde yazılan methodların bodysi olmaz. 
     Interfaceten inherit alan classlar interface'in metodlarını implemente etmek zorundadır. Sadece metod değil propertilerde.
     Interface'lerde field tanımı yapılamaz.
     Bir class birden fazla interface'ten inherit almış olabilir.
     Bir sınıfın sahip olduğu nitelikleri belirtmek amaçlı kullanılır.
     Erişim belirtme diye bir yöntem yok.(public,protected falan yok).
     
 ## InjectionLifeCycle <a href="https://github.com/ahmetsuhan/ASPNET.Core/tree/main/InjectionLifeCycle">Click</a>
  
  ### 1-) Transient 
            Bir request içerisinde Transient olarak ayağa kaldırdığımız nesneyi istediğin kadar çağır her çağırdığında yeni bir nesnedir. Oluşturulması istenen nesneden her requeste yenisini oluşturuyor. Request bitince her şey biter:)
  ### 2-) Singleton
            Proje ayakta olduğu sürece değer değişmez.
  ### 3-) Scoped 
            Bir request içerisinde Scoped ile ayağa kaldırılan bir nesne istediğin kadar çağır ilk oluşan nesne neyse ondan bir instance alıp bize verir. Yeni bir nesne veriyor ama ilk oluşan nesne onun aynısını veriyor.
        
   ### Constructor Injection <a href="https://github.com/ahmetsuhan/ASPNET.Core/blob/main/InjectionLifeCycle/InjectionLifeCycle/Controllers/ConstructorInjection.cs">Click</a>
            Injectionın constructor içerisinde alınması.
   ### Method Injection <a href="https://github.com/ahmetsuhan/ASPNET.Core/blob/main/InjectionLifeCycle/InjectionLifeCycle/Controllers/MethodInjection.cs">Click</a>
            Eğer ben inject ettiğim şeyi controllera geçirmek ihtiyacı değilse Method Injection kullanabilirim. Bir aksiyona bir metoda özel direkt methodlara inject yapabiliyorum.
   ### Property Injection <a href="https://github.com/ahmetsuhan/ASPNET.Core/blob/main/InjectionLifeCycle/InjectionLifeCycle/Controllers/PropertyInjection.cs">Click</a>
   
   <hr>
   
   ## Middleware
            Request ile Response Pipeline ini handle etmek için kullanılan yapılardır.
            
            use : iki middleware arasına gimek için kullanırız
            run : middlewareler arasındaki chain bağlantıyı kopartır. Yani run dan sonraki middlewareler çalışmaz.
            
        
