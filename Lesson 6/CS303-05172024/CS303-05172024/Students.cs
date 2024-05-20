
#region Notes

//Snif deklarasiyasi : Access modifier + class keyword + className
//Snif adları hər zaman böyük hərflə başlamalıdır, yəni Pascal case.

//Access modifiers : public protected internal private
//Access modifiers teyin etdiyimiz c# modulunun, yəni class, field  elcatanligini teyin edir.

//ctrl + R + G : lazimsiz usingleri silmek ucun shorthand

//Classların qarşısında heç bir Access Modifier keyword-ü yazılmazsa default olaraq Classlara internal access modifier teyin edilir, nested classlar yəni iç-içə classlar bu şamil edilmir. Çünki Nested classlar bizim classın üzvü yəni class memberları sayılır.

//Class memberler: Field

//Field və Property

//Classın scopeları daxilində təyin olunmuş dəyişənlər yəni variable-lar FIELD adlanır.

//Fieldlar həmçinin class memberlara daxildir.

//Access modifierlar həmçinin Fieldlara da aid edilir.

// Adlandırma zamanı Fieldlar declare olarkən adları kiçik hərflə başlayır, yəni adlandırma camel case olacaq.

//Biz classın scopeları daxilində təyin etdiyimiz field və propertyləri declare etdiyimiz yerdə dəyər set etməzsək yəni dəyər mənimsədməzsək, avtomatik olaraq default dəyər onlara set edilir.

//Biz daha əvvəldən görmüşdük ki variableları declare edən zaman onlara dəyər set olunmazsa özü avtomatik olaraq default dəyər set etmirdi. Fieldların adi variablelardan fərqi də budur. 2-ci fərqi isə class-a yəni bir type-a aid olmasıdır.

//database-də mənim table-larıma qarşılıq c#-da entitylər yəni modeller hal-hazırda anlıya biləcəyimiz şəkildə desək class-larımız qarşılıq gəlir.

//database-dəki table-ın daxilindəki columnlar bizim entitylərimizin yəni class-larımızın fieldlarına qarşılıq gəlir.

//Constructor - class-dan instance alınan zaman yəni classdan object törənən zaman işə düşən bir funksiya. C# daxilində source codelardan Assembly səviyəsinə keçid edilən zaman hər bir class üçün arxa tərəfdə boş constructor təyin edilir.

#endregion

namespace CS303_05172024;

//student class yaradılmalıdır əlavə olaraq daxilində Id(və ya fin kod), ad, soyad, yaş, email, username, password, telefon nömrəsi, address.


public class Students
{
    public int id;
    public string name;
    public string surname;
    public int age;
    public string email;
    public string pinCode;
    public string username;
    public string password;
    public string phoneNumber;
    public string address;


    //Boş, default və ya parameterless Constructor adlanır. Classdan instance almaq üçün məcbur şəkildə Constructor istifadə edilir.
    public Students()
    {

    }

}
