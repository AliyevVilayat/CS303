namespace CS303_05232024;

//Readonly => Həm Fieldlarla həm də Propertylərlə işlənə bilər.

//Yalnız və yalnız təyin olunduğu yerdə və constructor daxilində dəyər set oluna bilər.
//Qalan heç bir halda dəyər set oluna bilməz(Reflection xaric)

// Readonly Field => Readonly keyword-u ilə işlənir.

//Readonly Property => Readonly keyword istifade edilmir.

//Init only Property => Readonly Propertydən fərqi ondadır ki əlavə olaraq initialize olunduğu yerdə də dəyər mənimsətmək mümkündür. Və get methodu ilə yanaşı init methodu qeyd edilir.
    

//Const Field => Yalnız həmin Field təyin olunduğu yerdə dəyər mənimsədilir, başqa heç bir yerdə dəyər mənimsətmək olmaz.
// Classın objecti yox, bir başa olaraq adı ilə çağırılır. 


//Class members - fields, properties, constructor(s), indexer




//Exception, throw, try-catch, multiple catch
public class Teacher
{

    //1. Fields & Properties
    private int _id;
    private string _name;
    private string _surname;
    public const string pin = "AB12345";
    public readonly string seriaNumber = "AZE1234567";

    public int Id
    {
        get
        {
            return _id;
        }

        set
        {
            if (value > 0)
            {
                _id = value;
            }
            else
            {
                throw new Exception("Id menfi deyer qebul ede bilmez");
            }
        }
    }

    public string Name
    {
        get
        {
            return _name;
        }

        set
        {
            //if(value!="Vilayat" || value)
            _name = value;
        }
    }

    public string Surname
    {
        get
        {
            return _surname;
        }

        set
        {
            _surname = value;
        }
    }

    public string ReadonlyProp { get;  } = "Test";
    public string InitOnlyProp { get; init; } = "Test";

    //2.Constructors
    //access modifier + className

    public Teacher()
    {
        seriaNumber = "AA12345678";
        ReadonlyProp = "Test";
    }

    public Teacher(string seriaNumber)
    {
        this.seriaNumber = seriaNumber;
    }

    public Teacher(string name, string surname)
    {
        _name = name;
        Surname = surname;  
    } 

    //3.Methods
    public void ChangeConstVal()
    {
        //pin = "Test"; => compile time error
    }

    public void ChangeReadonlyVal() {

        //seriaNumber = "Test"; => compile time error
    }

    public void ChangeReadonlyPropVal() {

        //ReadonlyProp = "Test"; => compile time error
    }
}
