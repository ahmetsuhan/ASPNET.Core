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

