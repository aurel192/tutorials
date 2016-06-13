Static and Instance
 
using System;
namespace Kudvenkat20StaticAndInstance{
    class Circle{
        static float _PI;
        int _Radius;
 
        static Circle(){ // Static Constructor
            Circle._PI = 3.141F;
        }
 
        public Circle(int Radius) { // Instance Constructor
            this._Radius = Radius;
        }
 
        public float CalculateArea(){
            return this._Radius * this._Radius * Circle._PI;
        }
        public static void Print(){
            Console.WriteLine("Circle.Print()");
        }
    }
 
    class Program{
        static void Main(string[] args){
            Circle C1 = new Circle(5);
            float Area1 = C1.CalculateArea();
            Console.WriteLine("Area = {0}", Area1);
 
            Circle C2 = new Circle(6);
            float Area2 = C2.CalculateArea();
            Console.WriteLine("Area = {0}", Area2);
 
            Circle.Print();
 
            Console.Read();
        }
    }
}
/*
Area = 78,525
Area = 113,076
Circle.Print()
*/
Inheritance
using System;
namespace Kudvenkat21Inheritance {
    public class ParentClass {
        public ParentClass() {
            Console.WriteLine("ParentClass Constructor called");
        }
        public ParentClass(string Message) {
            Console.WriteLine(Message);
        }
    }
 
    public class ChildClass : ParentClass {
        public ChildClass() : base ("Derived Class controlling Parent class") {
            Console.WriteLine("ChildClass Constructor called");
        }
    }
 
    class Employee {       
        public string FirstName;
        public string LastName;
        public string Email;
 
        public void PrintFullName() {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
 
    class FullTimeEmployee : Employee {
        public float YearlySalary;
    }
 
    class PartTimeEmployee : Employee {
        public float HourlyRate;
    }
 
    class A : PartTimeEmployee{ // Multi level class inheritance       
    }
 
    class Program{
        static void Main(string[] args){
            ChildClass C1 = new ChildClass();
 
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "FTEFirst";
            FTE.LastName = "FTELast";
            FTE.YearlySalary = 456;
            FTE.PrintFullName();
 
            PartTimeEmployee PartTimeEmployee = new PartTimeEmployee();
            PartTimeEmployee.HourlyRate = 23;
 
            A a = new A();
            Console.Read();
        }
    }
}
/*
Derived Class controlling Parent class
ChildClass Constructor called
FTEFirst FTELast
*/
Method Hiding and Polymorpism
using System;
namespace Kudvenkat22MethodHiding {
    class Employee {
        public string FirstName;
        public string LastName;
        public string Email;
 
        public void PrintFullName() {
            Console.WriteLine(FirstName + " " + LastName + " Emp");
        }
    }
 
    class FullTimeEmployee : Employee {
        public float YearlySalary;
        public new void PrintFullName() {// new: no warning (method hiding)
            // base.PrintFullName(); or typecast ((Employee)PTE).PrintFullName();
            Console.WriteLine(FirstName + " " + LastName + " FT");
        }
    }
 
    class PartTimeEmployee : Employee{
        public float HourlyRate;
        public new void PrintFullName() {
            Console.WriteLine(FirstName + " " + LastName + " PTE");
        }
    }
 
    class Program {
        static void Main(string[] args) {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "FullTimeEmployee";
            FTE.PrintFullName();
 
            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "PartTimeEmployee";
            PTE.PrintFullName();
 
            ((Employee)PTE).PrintFullName();
           
            Console.Read();
        }
    }
}
/*
FullTimeEmployee FT
PartTimeEmployee PTE
PartTimeEmployee Emp
*/
Method Hiding vs Method Overriding
using System;
namespace Kudvenkat24MethodOverridingVsMethodHiding {
    public class BaseClass {
        public virtual void Print() {
            Console.WriteLine("Base Class");
        }
    }
 
    public class DerivedClass1 : BaseClass{
        public new void Print() { // Method Hiding 
            Console.WriteLine("Derived Class MH");
        }
    }
 
    public class DerivedClass2 : BaseClass {
        public override void Print() {    // Method Overriding               
            Console.WriteLine("Derived Class MO");
        }
    }
 
    class Program {
        static void Main(string[] args) {
            BaseClass B = new BaseClass();
            B.Print(); // Base Class
 
            BaseClass B1 = new DerivedClass1();
            B1.Print(); // Base Class
 
            DerivedClass1 D1 = new DerivedClass1();
            D1.Print(); // Derived Class MH
 
            DerivedClass2 D2 = new DerivedClass2();
            D2.Print();  // Derived Class MO
 
            Console.Read();
        }
    }
}
/*
Base Class
Base Class
Derived Class MH
Derived Class MO
*/
Method Overloading
 
using System;
namespace Kudvenkat25MethodOverloading {
    class Program {
        static void Main(string[] args){
            int res;
 
            Add(1, 2, 3, out res, 100, 200);
            Console.WriteLine(res);
 
            Console.Read();
        }
 
        public static int Add(int FN, int SN){
            Console.WriteLine("Sum = {0}", FN + SN);
            return FN + SN;
        }
 
        public static void Add(int FN, int SN, int TN){
            Console.WriteLine("Sum = {0}", FN + SN);
        }
 
        public static void Add(int FN, int SN, int TN, out int RES, params int[] numbers){
            int result;
            result = FN + SN + TN;
            foreach ( var n in numbers ) {
                result += n;
            }
            Console.WriteLine("Sum = {0}", result); // Sum = 306
            RES = result;
        }
 
        public static void Add(float FN, float SN, float TN){
            Console.WriteLine("Sum = {0}", FN + SN);
        }
 
        public static void Add(float FN, float SN, float TN, out float RES){
            Console.WriteLine("Sum = {0}", FN + SN);
            RES = FN + SN + TN;
        }
 
    }
}
/*
Sum = 306
306
*/
Properties
using System;
namespace Kudvenkat26WhyProperties {
    class Student {  // Class is reference type
        private int _id;
        private string _Name;
        private int _PassMark = 35;
        private string _city;
 
        public string City { get; set; } // Auto Implemented properties
        public void SetId(int Id){       // Getter and Setter methods
            if (Id<=0){
                throw new Exception("Student ID cannot be negative");
            }
            this._id = Id;
        }
        public int GetId() {
            return _id;
        }       
        public int Id { // Read/Write property
            set { if (value >= 0) this._id = value; else { throw new Exception("Student ID cannot be negative"); } }
            get { return this._id; }
        }
        public int PassMark {  // Read only property
            get { return this._PassMark; }  // Get Accessor
        }
        public void SetName(string Name) {
            if (string.IsNullOrEmpty(Name)) {
                throw new Exception("Name cannot be null or empty");
            }
            this._Name = Name;
        }
        public string GetName() {
            return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
            /* if (string.IsNullOrEmpty(this._Name))  return "NoName"; else  return _Name;  */
        }
        ~Student() { }  // Destructor
    }
 
    public struct Customer { // Struct is value type
        private int _id;
        private string _name;
        public string Name{
            get{return _name;}
            set{_name = value;}
        }
        // public int ID { get; set; }
        public int Id{
            get{return _id;}
            set{_id = value;}
        }
        public Customer(int Id,string Name) {
            this._id = Id;
            this._name = Name;
        }
        public void PrintDetails() {
            Console.WriteLine("Id = {0}  Name = {1}",this._id,this._name);
        }
    }
 
    class Program {
        static void Main(string[] args) {
            Student S1 = new Student();
            Student S2 = new Student();
            S1.SetId(111);
            S2.Id = 222;
            S2.SetName("NaMee");
            S2.City = "Cityy";
            // S1.SetName(null); S1.SetName("");
 
            Console.WriteLine("Id: " + S1.GetId() + " Name: " + S1.GetName());
            Console.WriteLine("Id: {0} Name: {1}", S2.GetId(), S2.GetName());
            Console.WriteLine("----------------");
            S1 = S2;
            Console.WriteLine($"Id: {S1.Id} Name: {S1.GetName()}");
            Console.WriteLine($"Id: {S2.Id} Name: {S2.GetName()}");
            Console.WriteLine("----------------");
            S1.SetName("egy");
            Console.WriteLine($"Id: {S1.Id} Name: {S1.GetName()}");
            Console.WriteLine($"Id: {S2.Id} Name: {S2.GetName()}");
            Console.WriteLine("----------------");
            S2.SetName("KETTO");
            Console.WriteLine($"Id: {S1.Id} Name: {S1.GetName()}");
            Console.WriteLine($"Id: {S2.Id} Name: {S2.GetName()}");
 
            Customer C1 = new Customer(101, "Cust1");
            C1.PrintDetails();
 
            Customer C2 = new Customer();
            C2.PrintDetails();
 
            Customer C3 = new Customer {
                Id = 321,
                Name = "Third"
            };
            C3.PrintDetails();
 
            C3 = C2;
            C3.PrintDetails();
            C3.Name = "C3Name";
            C3.PrintDetails();
 
            Console.Read();
        }
    }
}
/*
Id: 111 Name: No Name
Id: 222 Name: NaMee
----------------
Id: 222 Name: NaMee
Id: 222 Name: NaMee
----------------
Id: 222 Name: egy
Id: 222 Name: egy
----------------
Id: 222 Name: KETTO
Id: 222 Name: KETTO
Id = 101  Name = Cust1
Id = 0  Name =
Id = 321  Name = Third
Id = 0  Name =
Id = 0  Name = C3Name
*/
Structs
using System;
namespace Kudvenkat28Structs {
    public struct Customer {
        private int _id;
        private string _name;
        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        public int ID {
            get { return _id; }
            set { this._id = value; }           
        }
        public Customer (int Id,string Name){
            this._id = Id;
            this._name = Name;
        }
        public void PrintDetails() {
            Console.WriteLine("Id={0} Name={1}",this._id,this._name);
        }
    }
 
    class Program {
        static void Main(string[] args){
            Customer C1 = new Customer(111, "Mark");
            C1.PrintDetails();
            Customer C2 = new Customer();
            C2.PrintDetails();
            C2.ID = 222;
            C2.Name = "John";
            C2.PrintDetails();
            Customer C3 = new Customer
            {
                ID = 333,
                Name = "Rob"
            };
            C3.PrintDetails();
 
            Console.ReadKey();
        }
    }
}
/*
Id=111 Name=Mark
Id=0 Name=
Id=222 Name=John
Id=333 Name=Rob
*/
Interfaces
using System;
namespace Kudvenkat30Interfaces {
 
    interface ICustomer1 {
        void Print1();
    }
 
    interface ICustomer2 : ICustomer1 {
        void Print2();
    }
 
    public class Customer : ICustomer2 {
        public void Print1() {
            Console.WriteLine("Print1");
        }
        public void Print2() {
            Console.WriteLine("Print2");
        }
    }
 
    interface I1 {
        void InterfaceMethod();
    }
 
    interface I2 {
        void InterfaceMethod();
    }
 
    class Program : I1 , I2 { // Class can inherit from multiple interfaces
        public void InterfaceMethod() {  // Normal (Default)
            Console.WriteLine("I1 Interface Method");
        }
        void I2.InterfaceMethod() {  // Implicit
            Console.WriteLine("I2 Interface Method");
        }
 
        static void Main(string[] args) {
            Customer C1 = new Customer();
            C1.Print1(); // Print1
            C1.Print2(); // Print2
 
            ICustomer1 I1 = new Customer();
            I1.Print1(); // Print1
            ICustomer2 I2 = new Customer();
            I2.Print1(); // Print1
            I2.Print2(); // Print2
 
            Program P = new Program();
            // P.InterfaceMethod(); // I1 Interface Method
            ((I1)P).InterfaceMethod(); // I1 Interface Method
            ((I2)P).InterfaceMethod(); // I2 Interface Method
 
            I1 i11= new Program();
            i11.InterfaceMethod(); // I1 Interface Method
 
            Program PD = new Program();
            PD.InterfaceMethod(); // I1 Interface Method
 
            Console.Read();
        }
    }
}
/*
Print1
Print2
Print1
Print1
Print2
I1 Interface Method
I2 Interface Method
I1 Interface Method
I1 Interface Method
*/
Abstract Classes
using System;
 
namespace Kudvenkat32AbstractClasses {
 
    public abstract class Customer {
 
        public abstract void Print();
 
        public void Print2() {
            Console.WriteLine("Print2()");
        }
        // Abstract methods cannot have implementation
    }
 
    class Program : Customer {
 
        public override void Print() {  // providing implementation for the abstract method
            Console.WriteLine("Print Method");
        }
 
        static void Main(string[] args) {           
            Program P = new Program();
            P.Print();
            P.Print2();
             
            Console.ReadKey();
        }
    }
}
/*
Print Method
Print2()
 */
Abstract Classes vs Interfaces
using System;
 
namespace Kudvenkat33DiffBetwAbstractCAndInterfaces{
 
    public abstract class Customer { // can inherit from AC or IF
        int ID;
        public void Print() {
            Console.WriteLine("Print");
        }
    }
 
    public interface ICustomer { // No fields or implementation
        void Print();    
    }
 
    class A {
        public virtual void Print() {
            Console.WriteLine("A implementation");
        }
    }
 
    class B : A {
        public override void Print() {
            Console.WriteLine("B implementation");
        }
    }
 
    class C : A {
        public override void Print() {
            Console.WriteLine("C implementation");
        }
    }
 
    class D: B {  // Diamond problem, ambiguity
        public override void Print() {
            Console.WriteLine("D implementation");
        }
    }
 
    interface IA {
        void AMethod();
    }
 
    interface IB {
        void BMethod();
    }
 
    class AA : IA {
        public void AMethod() {
            Console.WriteLine("AA");
        }
    }
 
    class BB : IB {
        public void BMethod() {
            Console.WriteLine("BB");
        }
    }
 
    class AB: IA , IB { // Multiple class inheritance using interfaces
        AA a = new AA();
        BB b = new BB();
        public void AMethod() {
            // Console.WriteLine("AA");
            a.AMethod();
        }
        public void BMethod(){
            // Console.WriteLine("BB");
            b.BMethod();
        }
    }
 
    class Program {
        static void Main(string[] args) {
            D d = new D();
            d.Print();
 
            AB ab = new AB();
            ab.AMethod();
            ab.BMethod();
           
            Console.ReadKey();
        }
    }
}
/*
D implementation
AA
BB
*/
Delegate
using System;
 
namespace Kudvenkat36Delegate {
 
    public delegate void HelloFunctionDelegate(string Message);
 
    class Employee {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligableToPromote) {
            foreach (Employee employee in employeeList) {
                if (IsEligableToPromote(employee)) {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }
        }
    }
 
    delegate bool IsPromotable(Employee empl);
 
    class Program {
        static void Main(string[] args) {  // Delegate is a typesafe function pointer, good for: non hardcoded logic, reusable, for framework
            HelloFunctionDelegate HFD = new HelloFunctionDelegate(Hello);
            HFD("Hello From Delegate");
 
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            empList.Add(new Employee() { ID = 102, Name = "Mike", Salary = 4000, Experience = 4 });
            empList.Add(new Employee() { ID = 103, Name = "John", Salary = 6000, Experience = 6});
            empList.Add(new Employee() { ID = 104, Name = "Todd", Salary = 3000, Experience = 3 });
 
            IsPromotable promotable = new IsPromotable(Promote);           
            Employee.PromoteEmployee(empList,promotable);
            Employee.PromoteEmployee(empList, emp => emp.Experience >= 5); // inline Lambda expresion
 
            Console.Read();
        }
 
        public static void Hello(string str) {
            Console.WriteLine(str);
        }
 
        public static bool Promote (Employee emp) {
            if (emp.Experience >= 5)
                return true;
            else return false;
        }
    }
}
/*
Hello From Delegate
Mary promoted
John promoted
Mary promoted
John promoted
*/
Exception Handling
using System;
using System.IO;
 
namespace Kudvenkat40ExceptionHandling {
    class Program {
        static void Main(string[] args) {
            StreamReader sr = null;
            try {
                sr = new StreamReader(@"C:\Users\Aurel\Documents\asd.txt");
                Console.WriteLine(sr.ReadToEnd());
            }            
            catch (FileNotFoundException ex) {
                Console.WriteLine(ex.Message + "\n - \n" + ex.StackTrace);
                Console.WriteLine($"Please check if the file \"{ex.FileName}\" exist");
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally {
                if (sr != null)
                    sr.Close(); // release the resource
            }                   
            try { // Current Exception = File not found
                try { // Inner Exception = numbers...
                    Console.WriteLine("First Number:");
                     int FN = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Second Number:");
                    int SN = Convert.ToInt32(Console.ReadLine());
                    int Res = FN / SN;
                    Console.WriteLine("Result = " + Res);
                }
                catch (Exception e)  {
                    string path = @"C:\Users\Aurel\Documents\asd.txt";
                    if (File.Exists(path)) {
                        StreamWriter sw = new StreamWriter(path);
                        sw.Write(e.GetType().Name, e.Message);
                        sw.Close();
                        throw new Exception("Error", e);
                    }
                    else {
                        throw new FileNotFoundException(path + " is not present", e);
                    }
                }
            }
            catch (Exception exc) {
                Console.WriteLine("\nCurrent Exception:" + exc.GetType().Name);
                if (exc.InnerException != null)
                    Console.WriteLine("\nInner Exception:" + exc.InnerException.GetType().Name);
            }
          
            Console.ReadKey();
        }
    }
}
/*
DivideByZeroException
First Number:
10
Second Number:
3
Result = 3
 
FormatException
First Number:
5
Second Number:
0
Current Exception:Exception
Inner Exception:DivideByZeroException
 
DivideByZeroException
First Number:
3
Second Number:
0
Current Exception:FileNotFoundException
Inner Exception:DivideByZeroException
*/
Custom Exceptions
using System;
using System.Runtime.Serialization;
 
namespace Kudvenkat42CustomExceptions {
    class Program {
        static void Main(string[] args) {
            // throw new FileNotFoundException("File X is not found");
            try {
                throw new UserAlreadyLoggedInException(">>>UserAlreadyLoggedInException<<<");
            }
            catch (UserAlreadyLoggedInException ex) {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
    [Serializable]
    public class UserAlreadyLoggedInException : Exception {
        public UserAlreadyLoggedInException() : base(){}
        public UserAlreadyLoggedInException (string message) : base(message){}   
        public UserAlreadyLoggedInException (string message, Exception innerException) : base(message, innerException){}
        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context,string message, Exception innerException) : base(message, innerException){}
    }
}
Exception Handling abuse
using System;
namespace Kudvenkat43ExceptionHandlingAbuse{
    class Program{
        static void Main(string[] args){
            try{
                Console.WriteLine("Please enter a numerator!");
                int Numerator;
                bool IsNumeratorConversionSuccessfull = Int32.TryParse(Console.ReadLine(), out Numerator);
                if (IsNumeratorConversionSuccessfull){
                    Console.WriteLine("Please enter denominator!");
                    int Denominator;
                    bool IsDenominatorConversionSuccessfull = Int32.TryParse(Console.ReadLine(), out Denominator);                   
                    if (IsDenominatorConversionSuccessfull && Denominator != 0){
                        int Result = Numerator / Denominator;
                        Console.WriteLine("Result = " + Result);
                    }
                    else{
                        if (Denominator == 0){
                            Console.WriteLine("denominator cannot be zero");
                        }
                        else{
                            Console.WriteLine("Denominator should be a valid number between {0} and {1}", Int32.MinValue, Int32.MaxValue);
                        }
                    }
                }
                else{
                    Console.WriteLine("Numerator should be a valid number between {0} and {1}", Int32.MinValue, Int32.MaxValue);
                }
               
            }
            catch (Exception ex){
                Console.WriteLine(ex.Message);
            }          
            Console.Read();
        }
    }
}
Enums
using System;
 
namespace Kudvenkat45Enums {
 
    class Program {
        static void Main(string[] args) {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer {
                Name = "Mark",
                Gender = Gender.Male
            };
            customers[1] = new Customer {
                Name = "Mary",
                Gender = Gender.Female
            };
            customers[2] = new Customer {
                Name = "Sam",
                Gender = Gender.Unknown
            };
            foreach (Customer c in customers) {
                Console.WriteLine("Name: " + c.Name + " Gender: " + c.Gender);
            }
 
            Console.WriteLine(Enum.GetValues(typeof(Gender)));
 
            short[] Values = (short[])Enum.GetValues(typeof(Gender));
            foreach (short v in Values) {
                Console.WriteLine(v); // 0, 1 ,2
            }
 
            string[] Names = Enum.GetNames(typeof(Gender));
            foreach (var n in Names) {
                Console.WriteLine(n); // Unknown,Male,Female
            }
            Gender gender = (Gender)5;
            int num = (int)Gender.Unknown;
            Season s = (Season)Gender.Male;
 
            Console.Read();
        }
 
        public static string GetGender(Gender gender) {
            switch (gender) {
                case Gender.Unknown: return "Unknown";
                case Gender.Male:    return "Male";
                case Gender.Female:  return "Female";
                default:             return "Invalid";
            }
        }
    }
 
    public enum Gender : short {
        Unknown, Male, Female
    }
    public enum Season {
        Winter = 1, Spring = 2, Summer = 3
    }
 
    public class Customer {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        //public int Gender { get; set; }  // 0 unknown, 1 Male, 2 Female
    }
}
/*
Name: Mark Gender: Male
Name: Mary Gender: Female
Name: Sam Gender: Unknown
Kudvenkat45Enums.Gender[]
0
1
2
Unknown
Male
Female
*/                                                                                                        
Access Modifiers
using System;
 
namespace Kudvenkat49AccessModifiers {
    #region Customer
    public class Customer {
        private int _id; // Instance field
        protected int _ccid;
        public int ID {
            get { return _id; }
            set { _id = value; }
        }
    }
    #endregion
 
    public class CorporateCustomer : Customer {
        public void PrintID() {
            CorporateCustomer CC = new CorporateCustomer();
            CC._ccid = 101;
            base._ccid = 102;
            this._ccid = 103;
        }
    }
 
    class Program {
        static void Main(string[] args) {
 
        }
    }
}
/*
Access modifier        Accessibility
Private:            Only within the containing class
Public:             Anywhere, No restrictions
Protected:          Within the containing types (classes) and the types derived from the containing type
Internal:           Anywhere within the containing assembly
Protected Internal: Anywhere within the containing assembly, and from within a derived class in any another assembly
 
Default access modifier For types (class, delegeate, struct) is internal.
Default access modifier For types members (method) is private.   
*/
Attributes
using System;
using System.Collections.Generic;
 
namespace Kudvenkat52Attributes {
    class Program {
        static void Main(string[] args) {
            Calculator.Add(10, 20);
            Calculator.Add(new List<int>() { 10, 20, 30, 40 });           
        }
    }
 
    public class Calculator {
        [Obsolete("Use Add(List<int> Numbers)")] // outdated
        public static int Add(int FirstNumber, int SecondNumber) {
            return FirstNumber + SecondNumber;
        }
 
        public static int Add(List<int> Numbers) {
            int sum = 0;
            foreach (int n in Numbers) {
                sum = sum + n;
            }
            return sum;
        }
    }
}
Reflection
using System;
using System.Reflection;
 
namespace Kudvenkat53Reflection {
    class Program {
        static void Main(string[] args) {
            Customer C1 = new Customer();
 
            Type T = C1.GetType();
            //Type T = Type.GetType("Kudvenkat53Reflection.Customer");
            //Type T = typeof(Customer);
 
            Console.WriteLine(T.FullName);
            PropertyInfo[] Properties = T.GetProperties();                                   
            foreach (PropertyInfo p in Properties) {
                Console.WriteLine(p.PropertyType.Name + " " + p.Name);
            }
            MethodInfo[] Methods = T.GetMethods();
            foreach (MethodInfo m in Methods) {
                Console.WriteLine(m.ReturnType + " " + m.Name);
            }
            ConstructorInfo[] Constructors = T.GetConstructors();
            foreach (ConstructorInfo c in Constructors) {
                Console.WriteLine(c.ToString());
            }
            Console.Read();
        }
    }
 
    public class Customer {
        public int id { get; set; }
        private string Name { get; set; } // Nem látszik
 
        public Customer(int ID, string Name) {
            this.id = ID;
            this.Name = Name;
        }
 
        public Customer() {
            this.id = -1;
            this.Name = string.Empty;
        }
 
        public void PrintID() {
            Console.WriteLine("ID={0}", this.id);
        }
 
        public void PrintName() {
            Console.WriteLine("Name={0}", this.Name);
        }
    }
 
}
/*
Kudvenkat53Reflection.Customer
Int32 id
System.Int32 get_id
System.Void set_id
System.Void PrintID
System.Void PrintName
System.String ToString
System.Boolean Equals
System.Int32 GetHashCode
System.Type GetType
Void.ctor(Int32, System.String)
Void.ctor()
*/
Reflection Example
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;
 
namespace Kudvenkat54ReflectionExample {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
 
        private void button_Click(object sender, RoutedEventArgs e) {
            string TypeName = textBox.Text;
            Type T = Type.GetType(TypeName);
            lbmethods.Items.Clear();
            lbproperties.Items.Clear();
            lbconstructors.Items.Clear();
            MethodInfo[] Methods = null;
            PropertyInfo[] Properties = null;
            ConstructorInfo[] Constructors = null;
            try {
                Methods = T.GetMethods();
                Properties = T.GetProperties();
                Constructors = T.GetConstructors();
                foreach (MethodInfo m in Methods) {
                    lbmethods.Items.Add(m.ReturnType + " " + m.Name);
                }
                foreach (PropertyInfo p in Properties) {
                    lbproperties.Items.Add(p.PropertyType.Name + " " + p.Name);
                }
                foreach (ConstructorInfo c in Constructors) {
                    lbconstructors.Items.Add(c.ToString());
                }
            }
            catch{
            }
        }
    }
}
<Window x:Class="Kudvenkat54ReflectionExample.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:Kudvenkat54ReflectionExample"
        mc:Ignorable="d"
        Title="MainWindow" Height="630.825" Width="887.397">
    <Grid>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="19*"/>
            <ColumnDefinition Width="518*"/>
        </Grid.ColumnDefinitions>
        <Button x:Name="button" Content="Discover Type Info" HorizontalAlignment="Left" Margin="708,10,0,0" VerticalAlignment="Top" Width="115" Click="button_Click" Grid.Column="1" Height="24"/>
        <Label x:Name="label" Content="Type Name" HorizontalAlignment="Left" Margin="10,8,0,0" VerticalAlignment="Top" Grid.ColumnSpan="2"/>
        <TextBox x:Name="textBox" HorizontalAlignment="Left" Height="23" TextWrapping="Wrap" Text="" VerticalAlignment="Top" Width="637" Margin="66,11,0,0" Grid.Column="1"/>
        <Label x:Name="label_Copy" Content="Methods" HorizontalAlignment="Left" Margin="10,39,0,0" VerticalAlignment="Top" Grid.ColumnSpan="2"/>
        <Label x:Name="label_Copy1" Content="Properties" HorizontalAlignment="Left" Margin="424,34,0,0" VerticalAlignment="Top" Grid.Column="1"/>
        <Label x:Name="label_Copy2" Content="Constructors" HorizontalAlignment="Left" Margin="746,39,0,0" VerticalAlignment="Top" Grid.Column="1"/>
        <ListBox x:Name="lbmethods" HorizontalAlignment="Left" Height="502" Margin="10,70,0,0" VerticalAlignment="Top" Width="285" Grid.ColumnSpan="2"/>
        <ListBox x:Name="lbproperties" HorizontalAlignment="Left" Height="502" Margin="269,70,0,0" VerticalAlignment="Top" Width="293" Grid.Column="1"/>
        <ListBox x:Name="lbconstructors" HorizontalAlignment="Left" Height="502" Margin="567,70,0,0" VerticalAlignment="Top" Width="256" Grid.Column="1"/>
 
    </Grid>
</Window>
// System.Console, System.String
Late Binding using reflection
using System;
using System.Reflection;
 
namespace Kudvenkat55LateBindingUsingReflectionn {
    class Program {
        static void Main(string[] args) {          
            Customer C1 = new Customer(); // Early Binding
            string fullName = C1.GetFullName("fn", "ln");
            Console.WriteLine("Full Name = {0}",fullName);
          
            Assembly executingAssembly = Assembly.GetExecutingAssembly(); // Late Binding
            Type customerType = executingAssembly.GetType("Kudvenkat55LateBindingUsingReflectionn.Customer");
            object customerInstance = Activator.CreateInstance(customerType);
            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");
            string[] parameters = new string[2];
            parameters[0] = "00";
            parameters[1] = "11";
            string fullName2 = (string)getFullNameMethod.Invoke(customerInstance,parameters);           
            Console.WriteLine("Full Name = {0}", fullName2);
 
            Console.Read();
        }
    }
 
    public class Customer {
        public string GetFullName(string FN, string LN) {
            return FN + " " + LN;
        }
    }   
}
Generics
 
using System;
 
namespace Kudvenkat56Generics {
    class Program {
        static void Main(string[] args) {
            bool? Equal = null;
            //Equal = Calculator.AreEqual(2, 1);          
            if (Equal.HasValue) {
                if (Equal == true)
                    Console.WriteLine("Equal");
                else
                    Console.WriteLine("Not Equal");
            }
            else
                Console.WriteLine("Null");         
 
            Equal = Calculator.AreEqual("Aa","Bb");
            Equal = Calculator2<string>.AreEqual("Aa", "Bb");
            if (Equal.HasValue) {
                if (Equal == true)
                    Console.WriteLine("Equal");
                else
                    Console.WriteLine("Not Equal");
            }
            else
                Console.WriteLine("Null");
 
            Console.Read();
        }
    }
 
    public class Calculator {
        public static bool AreEqual<T>(T a, T b) { // public static bool AreEqual(object a, object b)  // Converting value types to reference types is called boxing
            return a.Equals(b);
        }
    }
 
    public class Calculator2 <T> {
        public static bool AreEqual(T a, T b) {
            return a.Equals(b);
        }
    }
}
/*
Null
Not Equal
*/
Why Override ToString
using System;
 
namespace Kudvenkat57OverrideToSting {
    class Program {
        static void Main(string[] args) {
            int num = 10;
            Console.WriteLine(num.ToString());
            Customer C1 = new Customer();
            C1.FirstName = "FN"; C1.LastName = "LN";
            Console.WriteLine(C1.ToString());  // ez fagy ha C1 = null, a Convert nem
            Console.WriteLine(Convert.ToString(C1) + "\n");
 
            Customer C2 = C1;
            Console.WriteLine(C1 == C2); // Pointing to same objects, references are equal
            // C2.FirstName = "asd";
            Console.WriteLine(C1.Equals(C2) + "\n"); // Checks value equality
 
            Customer C3 = new Customer();
            C3.FirstName = "FN"; C3.LastName = "LN";
            Console.WriteLine(C1 == C3);           
            Console.WriteLine(C1.Equals(C3) + "\n");
 
            Direction dir1 = Direction.East;
            Direction dir2 = Direction.West;
            Console.WriteLine(dir1 == dir2);
            Console.WriteLine(dir1.Equals(dir2));
 
            Console.Read();
        }
    }
    public class Customer {
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public override string ToString(){ // overriding ToString
            return FirstName + " " + LastName; // FN LN
            //return base.ToString(); // Kudvenkat57OverrideToSting.Customer
        }
        public override bool Equals(object obj) {
            if (obj == null)
                return false;
            if (!(obj is Customer))
                return false;
            return this.FirstName == ((Customer)obj).FirstName && this.LastName == ((Customer)obj).LastName;
           //return base.Equals(obj);
        }
        public override int GetHashCode() {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
            // return base.GetHashCode();
        }
    }
    public enum Direction {
        East,West,North,South
    }
}
 
/*
10
FN LN
FN LN
 
True
True
 
False
True
 
False
False
*/
String and StringBuilder
using System;
using System.Text;
 
namespace Kudvenkat60StringAndStringBuilder {
    class Program {
        static void Main(string[] args) {
            string Str = "C#";  //imutable, makes lot of garbage
            Str += "Tutorial";
            Console.WriteLine(Str);
            StringBuilder StrB = new StringBuilder("C#"); // no garbage
            StrB.Append("Tutorial");
            Console.WriteLine(StrB);
            Console.WriteLine(StrB.ToString());           
            for (int i = 0; i < 20000; i++) {
                Str += i.ToString() + " " ;
                StrB.Append(i.ToString());
            }
            Console.Read();
        }
    }
}
Partial Class
    public partial class PartialCustomer {
        private string _firstName;
        private string _lastName;
 
        public string FirstName {
            get{return _firstName;}
            set{_firstName = value;}
        }
        public string LastName{
            get{return _lastName;}
            set{_lastName = value;}
        }
    }
 
    public partial class PartialCustomer{
        public string GetFullName(){
            return _firstName + " " + _lastName;
        }
    }
Partial Methods
 
namespace Kudvenkat63PartialMethod {
 
    public partial class SamplePartialClass {
 
        partial void SamplePartialMethod();
 
        public void PublicMethod() {
            Console.WriteLine("PublicMethod Invoked");
            SamplePartialMethod();
        }
    }
}
 
namespace Kudvenkat63PartialMethod {
    public partial class SamplePartialClass {
        partial void SamplePartialMethod() {
            Console.WriteLine("SamplePartialMethod Invoked");
        }
    }
}
 
using System;
namespace Kudvenkat63PartialMethod {
    class Program {
        static void Main(string[] args) {
            SamplePartialClass SPC = new SamplePartialClass();
            SPC.PublicMethod();
 
            Console.ReadKey();
        }
    }
}
/*
PublicMethod Invoked
SamplePartialMethod Invoked
*/
Overloading Indexers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 
namespace Kudvenkat65Indexers {
    public class Employee {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    public class Company {
        private List<Employee> listEmployees;
 
        public Company() {
            listEmployees = new List<Employee>();
            listEmployees.Add(new Employee() { EmployeeId = 1, Name= "NAME111", Gender = "Male" });
            listEmployees.Add(new Employee { EmployeeId = 2, Name = "22", Gender = "Female" });
            listEmployees.Add(new Employee { EmployeeId = 3, Name = "333", Gender = "Female" });
        }
       
        public string this[int id] {
            get { // c[1] --> "NAME111"
                return listEmployees.FirstOrDefault(emp => emp.EmployeeId == id).Name;
            }
            set { // c[1] = "CHANGED!"
                listEmployees.FirstOrDefault(emp => emp.EmployeeId == id).Name = value;
            }
        }
        /*
        public string this[string gnd] {
            get {
                return listEmployees.Count(emp => emp.Gender == gnd).ToString();
            }
            set {
                foreach (Employee e in listEmployees){
                    if (e.Gender == gnd) {
                        e.Gender = value;
                    }
                }
            }
        }
        */
        public int this[string name] {
            get{   // c["NAME111"] --> 1   (GetID)
                foreach (Employee emp in listEmployees) {
                    if (emp.Name.Equals(name)) {
                        return emp.EmployeeId;
                    }
                }
                return -1;
            }
        }
 
        public int this [string name, string func] { // Change id,  c["OldName", "rename"] = "NewName";
            set {
                if (func == "rename") {
                    listEmployees.FirstOrDefault(emp => emp.Name == name).EmployeeId = value;
                }               
            }
        }
 
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 
namespace Kudvenkat65Indexers {
    public partial class _Default : Page {
        protected void Page_Load(object sender, EventArgs e) {
            Company c = new Company();
            Response.Write("<br/> Name of Employee With Id = 1: " + c[1]);           
            Response.Write("<br/> Name of Employee With Id = 2: " + c[2]);
            c[2] = "CHANGED!";
            Response.Write("<br/> Name of Employee With Id = 2: " + c[2]);
            Response.Write("<br/> Total Male Employees:" + c["Male"]);
            Response.Write("<br/> Total Female Employees:" + c["Female"]);
            //c["Male"] = "Female";
            Response.Write("<br/> Total Male Employees:" + c["Male"]);
            Response.Write("<br/> Total Female Employees:" + c["Female"]);
            Response.Write("<br/> ID of Employee With Name = NAME111: " + c["NAME111"].ToString());
            c[c["NAME111"]] = "CHANGEDTOO";
            Response.Write("<br/> Name of Employee With Id = 1: " + c[1]);
            c["CHANGEDTOO", "rename"] = 7;
            Response.Write("<br/> Name of Employee With Id = 7: " + c[7]);
            Response.Write("<br/> ID of Employee With Name = CHANGEDTOO: " + c["CHANGEDTOO"].ToString());
        }
    }
}
/*
Name of Employee With Id = 1: NAME111
Name of Employee With Id = 2: 22
Name of Employee With Id = 2: CHANGED!
Total Male Employees:-1
Total Female Employees:-1
Total Male Employees:-1
Total Female Employees:-1
ID of Employee With Name = NAME111: 1
Name of Employee With Id = 1: CHANGEDTOO
Name of Employee With Id = 7: CHANGEDTOO
ID of Employee With Name = CHANGEDTOO: 7
*/
Making method parameters optinal by specyfing parameter defaults, and Optional Attribute
 
using System;
using System.Runtime.InteropServices;
 
namespace Kudvenkat68OptMethodParameters {
    class Program {
        static void Main(string[] args) {
            int result;
            result = Add(10, 20);
            Console.WriteLine(result);           
            result = Add(10, 20, out result, 300, 400, 500);
            Console.WriteLine(result);
            Add(10, 20, out result, new object[]{ 300, 400, 500} );
            Console.WriteLine(result);
            result = AddParamsDEF(10, 20, new int[] { 300, 400, 500 });
            Console.WriteLine(result);
            result = AddParamsOPT(10, 20, new int []{ 30, 40, 50});
            Console.WriteLine(result);
            Test(7,14);       
            Test(7, c: 14);
 
            Console.ReadKey();
        }
 
        public static int Add(int fn, int sn) {
            return fn + sn;
        }
 
        // Method overloading // (...., int[] restOfNumbers)
        public static int Add(int FN, int SN, out int RES, params object[] restOfNumbers) {           
            int result = FN + SN;
            if (restOfNumbers != null) {
                foreach (int n in restOfNumbers) {
                    result += n;
                }
            }           
            RES = result;
            return result+1;
        }
 
        // Making method parameters optinal by specifying parameter defaults
        public static int AddParamsDEF(int FN, int SN, int[] restOfNumbers = null) {
            int result = FN + SN;
            if (restOfNumbers != null) {
                foreach (int n in restOfNumbers) {
                    result += n;
                }
            }
            return result + 2;
        }
 
        // Making method parameters optinal by using Optional Attribute
        public static int AddParamsOPT(int FN, int SN, [Optional] int[] restOfNumbers) {
            int result = FN + SN;
            if (restOfNumbers != null) {
                foreach (int n in restOfNumbers) {
                    result += n;
                }
            }
            return result + 3;
        }
 
        // Parameter defaults
        public static void Test(int a, int b = 10, int c = 20) {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
        }
 
    }
}
/*
30
1231
1230
1232
153
a = 7
b = 14
c = 20
a = 7
b = 10
c = 14
*/
Dictionary
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Kudvenkat72Dictionary {
    class Program {
        static void Main(string[] args) {
            Customer C1 = new Customer() { ID = 101, Name = "Mark", Salary = 5000 };
            Customer C2 = new Customer() { ID = 110, Name = "Pam", Salary = 6500 };
            Customer C3 = new Customer() { ID = 119, Name = "John", Salary = 3500 };
 
            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(C1.ID, C1);
            dictionaryCustomers.Add(C2.ID, C2);
            dictionaryCustomers.Add(C3.ID, C3);
 
            if (!dictionaryCustomers.ContainsKey(C1.ID)) {
                dictionaryCustomers.Add(C1.ID, C1);
            }
 
            Customer[] CustomersArray = new Customer[3];
            CustomersArray[0] = C1;
            CustomersArray[1] = C2;
            CustomersArray[2] = C3;
            Dictionary<int, Customer> dict = CustomersArray.ToDictionary(cust => cust.ID, cust => cust);
 
            List<Customer> CustomersList = new List<Customer>();
            CustomersList.Add(C1);
            CustomersList.Add(C2);
            Dictionary<int, Customer> dict2 = CustomersList.ToDictionary(cust => cust.ID, cust => cust);           
 
            foreach ( KeyValuePair<int,Customer> kvp in dict) {
                Console.WriteLine("kvp.Key {0}",kvp.Key);
                Customer Cust = kvp.Value;
                Console.WriteLine("ID {0} Name {1} Salary {2}\n", Cust.ID, Cust.Name, Cust.Salary);
            }
 
            Customer ResultC = null;
            if (dictionaryCustomers.ContainsKey(119)) {
                ResultC = dictionaryCustomers[119];
            }           
            Console.WriteLine("ID {0} Name {1} Salary {2}\n",ResultC.ID, ResultC.Name, ResultC.Salary);
 
            foreach(KeyValuePair<int,Customer> CustomerKeyValuePair in dictionaryCustomers) { // foreach (var ..
                Console.WriteLine("ID {0}",CustomerKeyValuePair.Key);
                Customer Cust = CustomerKeyValuePair.Value;
                Console.WriteLine("ID {0} Name {1} Salary {2}\n", Cust.ID, Cust.Name, Cust.Salary);
            }
 
            foreach (var key in dictionaryCustomers.Keys) {
                Console.WriteLine(key);
            }
           
            foreach (var val in dictionaryCustomers.Values){
                Console.WriteLine(val.ID + val.Name + val.Salary);
            }
 
            Customer CustRes;
            if ( dictionaryCustomers.TryGetValue(101, out CustRes) ) {
                Console.WriteLine("ID {0} Name {1} Salary {2}",CustRes.ID, CustRes.Name, CustRes.Salary);
            }
 
            Console.WriteLine("dictionaryCustomers.Count() = {0}", dictionaryCustomers.Count());
            Console.WriteLine("dictionaryCustomers.Count(kvp => kvp.Value.Salary > 4000) = {0}", dictionaryCustomers.Count(kvp => kvp.Value.Salary > 4000));
 
            dictionaryCustomers.Remove(101);
            dictionaryCustomers.Clear();
           
            Console.ReadKey();
        }
    }
    public class Customer {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
/*
kvp.Key 101
ID 101 Name Mark Salary 5000
 
kvp.Key 110
ID 110 Name Pam Salary 6500
 
kvp.Key 119
ID 119 Name John Salary 3500
 
ID 119 Name John Salary 3500
 
ID 101
ID 101 Name Mark Salary 5000
 
ID 110
ID 110 Name Pam Salary 6500
 
ID 119
ID 119 Name John Salary 3500
 
101
110
119
101Mark5000
110Pam6500
119John3500
ID 101 Name Mark Salary 5000
dictionaryCustomers.Count() = 3
dictionaryCustomers.Count(kvp => kvp.Value.Salary > 4000) = 2
*/
List Collection, Array to List, List to Dictionary
 
            Customer C1 = new Customer() { ID = 111, Name = "Mark", Salary = 5000, Type = "RetailCustomer" };
            Customer C5 = new Customer() { ID = 555, Name = "Otos", Salary = 3500, Type = "CorporateCustomer" };
 
            List<Customer> CustomerList = new List<Customer> (2);
            CustomerList.Add(C1);
            CustomerList.Insert(0, C3);
            CustomerList.RemoveAt(0);
            Console.WriteLine("index of C3:" + CustomerList.IndexOf(C3, 1,2));           
 
            if (CustomerList.Contains(C3)) Console.WriteLine("List contains C3 obj");
            if (CustomerList.Exists(cust => cust.Name.StartsWith("P"))) Console.WriteLine("Obj exist that StartsWith(\"P\")");
 
            Customer result = CustomerList.Find(cust => cust.Salary > 4000); // returns the first matching item       
            result = CustomerList.FindLast(cust => cust.Salary > 4000); // returns the last matching item
            List<Customer>ListOfWellPaidCustomers = CustomerList.FindAll(cust => cust.Salary > 4000); // returns  all the matching items
 
            SavingsCustomer SC = new SavingsCustomer();
            ListOfWellPaidCustomers.Add(SC);
 
            Console.WriteLine("CustomerList.FindIndex(c => c.Salary > 4000) = " + CustomerList.FindIndex(c => c.Salary > 4000));
            Console.WriteLine("CustomerList.FindIndex(2,c => c.Salary > 4000) = " + CustomerList.FindIndex(2, c => c.Salary > 4000));
            Console.WriteLine("CustomerList.FindLastIndex(c => c.Salary > 4000) = " + CustomerList.FindLastIndex(c => c.Salary > 4000));
 
            Customer[] CustomersArray = new Customer[3];
            CustomersArray[0] = C1;
            List<Customer> CustomerList = CustomersArray.ToList(); // Array to List
            Customer[] CustomerArray = CustomerList.ToArray();  // List to Array           
            Dictionary<int,Customer> DictionaryOfCustomers = CustomerList.ToDictionary(x => x.ID); // List to Dictionary, key=ID
 
            foreach(KeyValuePair<int,Customer> kvp in DictionaryOfCustomers) {
                Console.Write("key:" + kvp.Key);
                Console.WriteLine(" name: " + kvp.Value.Name);
            }
 
            List<Customer> CorporateCustomerList = new List<Customer>(2);
            CorporateCustomerList.Add(C4);
            CustomerList.AddRange(CorporateCustomerList);
 
            List<Customer> List2 = List1.GetRange(0, 3);  // List2 <-- List1 0,1,2
            foreach (Customer c in List2) {
                Console.WriteLine("name:" + c.Name + " Type" + c.Type);
            }
            List2.InsertRange(0, CorporateCustomerList);
            List2.Remove(C1);
            List2.RemoveRange(0,2);
            List2.RemoveAll(x => x.Type == "RetailCustomer");
 
    public class Customer {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }
    }
    public class SavingsCustomer : Customer {
    }
Sorting List of Simple and Complex types
 
            List<int> numbers = new List<int>() { 1, 8, 7, 5, 2, 3, 4, 9, 6 };
           
            numbers.Reverse();           
 
            List<string> Strings = new List<string>() {"A", "BB", "cccc", "D", "d" ,"eEe"};           
            Strings.Sort();
 
            CustomerList.Sort();
 
            SortByName SBN = new SortByName();                       
            CustomerList.Sort(SBN);
 
            Comparison<Customer> customerComparer = new Comparison<Customer>(CompareCustomer);
            CustomerList.Sort(customerComparer);
 
            CustomerList.Sort(delegate(Customer c1, Customer c2) { return c1.ID.CompareTo(c2.ID); });
 
            CustomerList.Sort((x, y) => x.ID.CompareTo(y.ID));
 
            Console.WriteLine("all salaries greater than 5000: " + CustomerList.TrueForAll(x => x.Salary > 5000));
 
        private static int CompareCustomer(Customer x, Customer y) {
            return x.ID.CompareTo(y.ID);
        }
 
    public class SortByName : IComparer<Customer> {
        public int Compare(Customer x, Customer y) {
            return x.Name.CompareTo(y.Name);
        }
    }
           
    public class Customer : IComparable<Customer> {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }
        public int CompareTo(Customer other) {
            // return this.Name.CompareTo(other.Name); // Sort by Name
            // return this.Salary.CompareTo(other.Salary); // Sort by Salary
            if (this.Salary > other.Salary) {
                return 1;
            }
            else if (this.Salary < other.Salary) {
                return -1;
            }
            else {
                return 0;
            }
        }       
    }
Searching in List and Dictionary
 
            List<Country> listCountries = new List<Country>();
            listCountries.Add(CNT1);
            listCountries.Add(CNT2);
            listCountries.Add(CNT3);
            listCountries.Add(CNT4);
            listCountries.Add(CNT5);          
            string strCountryCode=null;
            while (strCountryCode!="ESC") {
                Country resultCountry = null;
                do {
                    strCountryCode = Console.ReadLine().ToUpper();
                    resultCountry = listCountries.Find(country => country.Code == strCountryCode);
                    if (resultCountry != null) {
                        Console.WriteLine("Country: " + resultCountry.Name);
                    }
                } while (resultCountry == null && strCountryCode != "ESC");
            }
 
            Dictionary<string,Country> dictCountries = new Dictionary<string, Country>();
            dictCountries.Add(CNT1.Code, CNT1);
            dictCountries.Add(CNT2.Code, CNT2);
            dictCountries.Add(CNT3.Code, CNT3);
            dictCountries.Add(CNT4.Code, CNT4);
            dictCountries.Add(CNT5.Code, CNT5);
            string strCountryCode = null;
            while (strCountryCode != "ESC") {
                Country resultCountry = null;
                do {
                    strCountryCode = Console.ReadLine().ToUpper();
                    resultCountry = dictCountries.ContainsKey(strCountryCode) ? dictCountries[strCountryCode] : null;
                    if (resultCountry != null) {
                        Console.WriteLine("Country: " + resultCountry.Name);
                    }
                } while (resultCountry == null && strCountryCode != "ESC");
            }
 
    public class Country {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }
    }
Queue
            Customer C1 = new Customer() { ID = 101, Name = "Mark", Gender = "Male" };
            Customer C2 = new Customer() { ID = 102, Name = "Pamm", Gender = "Female" };
            Customer C3 = new Customer() { ID = 103, Name = "John", Gender = "Male" };
            Customer C4 = new Customer() { ID = 104, Name = "Natasha", Gender = "Female" };
            Customer C5 = new Customer() { ID = 105, Name = "Geza", Gender = "Male" };
 
            Queue<Customer> queueCustomer = new Queue<Customer>(); // FIFO
            queueCustomer.Enqueue(C1);
            queueCustomer.Enqueue(C2);
            queueCustomer.Enqueue(C3);
            queueCustomer.Enqueue(C4);
            queueCustomer.Enqueue(C5);
 
            Customer QRet1 = queueCustomer.Dequeue(); // Removes C1 from the queue, returns item
            Console.WriteLine(QRet1.ID + " " + QRet1.Name + "\tTotal items in Queue: " + queueCustomer.Count);           
 
            Customer QRet2 = queueCustomer.Dequeue();  // Remove C2 from the queue, returns item
            Console.WriteLine(QRet2.ID + " " + QRet2.Name + "\tTotal items in Queue: " + queueCustomer.Count);
 
            foreach (Customer C in queueCustomer) // not removes elements from queue
                Console.WriteLine(C.ID + " " + C.Name + "\tTotal items in Queue: " + queueCustomer.Count);           
 
            Customer CP = queueCustomer.Peek();  // not removes elements from queue
            Console.WriteLine(CP.ID + " " + CP.Name + "\tTotal items in Queue: " + queueCustomer.Count);
 
            CP = queueCustomer.Peek();
            Console.WriteLine(CP.ID + " " + CP.Name + "\tTotal items in Queue: " + queueCustomer.Count);
 
            if (queueCustomer.Contains(C1) )
                Console.WriteLine("C1 exists"); ;           
            else
                Console.WriteLine("C1 does Not exist"); ;
/*
101 Mark Total items in Queue: 4
102 Pamm Total items in Queue: 3
103 John Total items in Queue: 3
104 Natasha Total items in Queue: 3
105 Geza Total items in Queue: 3
103 John Total items in Queue: 3
103 John Total items in Queue: 3
C1 does Not exist
*/
Stack
            Stack<Customer> stackCustomers = new Stack<Customer>();  // LIFO
            stackCustomers.Push(C1);
            stackCustomers.Push(C2);
            stackCustomers.Push(C3);
            stackCustomers.Push(C4);
            stackCustomers.Push(C5);
 
            Customer SC1 = stackCustomers.Pop(); // Pops one element and returns and removes it
            Console.WriteLine(SC1.ID + " " + SC1.Name + "\tTotal items in Stack: " + stackCustomers.Count);
 
            Customer SC2 = stackCustomers.Pop();
            Console.WriteLine(SC2.ID + " " + SC2.Name + "\tTotal items in Stack: " + stackCustomers.Count);
 
            foreach(Customer C in stackCustomers)  // not removes elements from stack
                Console.WriteLine(C.ID + " " + C.Name + "\tTotal items in Queue: " + stackCustomers.Count);
 
            Customer SP = stackCustomers.Peek(); // not removes elements from stack
            Console.WriteLine(SP.ID + " " + SP.Name + "\tTotal items in Queue: " + stackCustomers.Count);
 
            SP = stackCustomers.Peek();
            Console.WriteLine(SP.ID + " " + SP.Name + "\tTotal items in Queue: " + stackCustomers.Count);
 
            if (stackCustomers.Contains(C1))
                Console.WriteLine("C1 exists \n");
            else
                Console.WriteLine("C1 does Not exist \n");
/*
105 Geza        Total items in Stack: 4
104 Natasha     Total items in Stack: 3
103 John        Total items in Queue: 3
102 Pamm        Total items in Queue: 3
101 Mark        Total items in Queue: 3
103 John        Total items in Queue: 3
103 John        Total items in Queue: 3
C1 exists
*/
Thread
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
 
namespace Kudvenkat88ThreadStartDelegate {
    class Program {
 
        public static void PrintSum(int sum) {
            Console.WriteLine("Sum of Numbers = " + sum);
        }
 
        static void Main(string[] args) {           
            Thread T1 = new Thread(Number.PrintNumbers); // Starting a Static function
            T1.Start();
            Thread T2 = new Thread(new ThreadStart(Number.PrintNumbers));
            T2.Start();
            Thread T3 = new Thread(delegate () { Number.PrintNumbers(); });
            T3.Start();
            Thread T4 = new Thread( () => Number.PrintNumbers() );
            T4.Start();
            Number Num = new Number(0); // Starting a Non Static function, after instanciating it
            Thread T5 = new Thread(Num.PrintNumbersNS);
            T5.Start();
 
            Thread.Sleep(200);
            Console.Write("Target num: ");
            Number N = new Number(0); // Starting a Non Static function, after instanciating it           
            object target = Console.ReadLine();
            ParameterizedThreadStart PTS = new ParameterizedThreadStart(N.PrintNumbersTarget);
            Thread T6 = new Thread(PTS); // Thread T6 = new Thread(N.PrintNumbersTarget);
            T6.Start(target); // Not Typsafe
            Thread.Sleep(200);            
 
            Console.Write("Target num: ");
            SumOfNumbersCallback callback = new SumOfNumbersCallback(PrintSum);
            int itarget = Convert.ToInt32(Console.ReadLine());
            SumCounter NP = new SumCounter(itarget,callback);
            Thread T8 = new Thread(new ThreadStart(NP.SumOfNumbers));
            T8.Start(); // TypeSafe
            while (true) {  // T8.Join; NP.result
                if (!T8.IsAlive) {
                    Console.WriteLine(NP.result);
                    break;
                }
            }
 
            Console.WriteLine("Main started");
            Thread T11 = new Thread(Program.Thread1Function);
            T11.Start();
            Thread T22 = new Thread(Program.Thread2Function);
            T22.Start();
            if (T11.Join(1000)) {
                Console.WriteLine("T11 completed in 1000ms");
            }
            else {
                Console.WriteLine("T11 NOT completed in 1000ms");
            }
            T22.Join();
            Console.WriteLine("T22 completed");
            for (int i=0; i<=20; i++) {
                if (T11.IsAlive) {
                    Console.WriteLine("T11 is still working");
                    Thread.Sleep(100);
                }
                else {
                    Console.WriteLine("T11 Completed!");
                    break;
                }
            }
            Console.WriteLine("Main Completed");
 
            Console.ReadKey();
        }
 
        public static void Thread1Function() {            
            Console.WriteLine("Thread1 started");
            Thread.Sleep(1845);
            //return 546;
        }
 
        public static void Thread2Function() {
            Console.WriteLine("Thread2 started");
            Thread.Sleep(1345);
        }
    }
 
    public delegate void SumOfNumbersCallback(int SumOfNumbers);
 
    class SumCounter {
        private int _target;
        SumOfNumbersCallback _callBackMethod;
        public int result;
        public SumCounter(int target, SumOfNumbersCallback callbackMethod) {
            this._target = target;
            this._callBackMethod = callbackMethod;
        }
        public void SumOfNumbers() {
            int sum = 0;
            for (int i = 0; i <= _target; i++) {
                sum += i;
            }
            result = sum;
            if (_callBackMethod != null) {
                _callBackMethod(sum);
            }
        }
    }
 
    class Number {
        private int _target;
        public Number(int target) {
            this._target = target;
        }
        public static void PrintNumbers() { // Statikus
            for (int i = 1; i <= 5; i++) {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public void PrintNumbersNS() {  // Példányosítható
            for (int i = 1; i <= 5; i++) {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public void PrintNumbersTarget(object target) {
            int number = 0;
            if (int.TryParse(target.ToString(), out number)) {
                for (int i = 1; i <= number; i++) {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
        public void PrintNumbersTypeSafe() {
            for (int i = 1; i <= _target; i++) {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
 
}
/*
1 1 2 3 4 5
2 1 2 3 4 5
1 2 3 4 3 4 5
1 2 3 4 5
5
Target num: 8
1 2 3 4 5 6 7 8
Target num: 15
Sum of Numbers = 120
120
Main started
Thread1 started
Thread2 started
T11 NOT completed in 1000ms
T22 completed
T11 is still working
T11 is still working
T11 is still working
T11 is still working
T11 is still working
T11 Completed!
Main Completed
*/
Deadlock
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
 
namespace Kudvenkat95Deadlock {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("main started");
            Account A = new Account(101, 5000);
            Account B = new Account(102, 3000);
 
            AccountManager accountManagerA = new AccountManager(A, B, 1000);
            Thread T1 = new Thread(accountManagerA.Transfer);
            T1.Name = "T1";
 
            AccountManager accountManagerB = new AccountManager(B, A, 2000);
            Thread T2 = new Thread(accountManagerB.Transfer);
            T2.Name = "T2";
 
            T1.Start();
            T2.Start();
 
            T1.Join();
            T2.Join();
            Console.WriteLine("main completed");
 
            Console.ReadKey();
        }
    }
 
    public class Account {
        int _id;
        double _balance;       
        public Account(int id, double balance) {
            this._id = id;
            this._balance = balance;
        }
        public int ID {
            get { return _id; }
        }
        public void Withdraw(double amount) {
            _balance -= amount;
        }
        public void Deposit(double amount) {
            _balance += amount;
        }
    }
 
    public class AccountManager {
        Account _fromAccount;
        Account _toAccount;
        double _amountToTransfer;
        public AccountManager(Account fromAccount, Account toAccount, double amountToTransfer) {
            this._fromAccount = fromAccount;
            this._toAccount = toAccount;
            this._amountToTransfer = amountToTransfer;
        }
 
        public void Transfer() {
            object lock1, lock2;
            if (_fromAccount.ID < _toAccount.ID) {
                lock1 = _fromAccount;
                lock2 = _toAccount;
            }
            else {
                lock1 = _toAccount;
                lock2 = _fromAccount;
            }       
            Console.WriteLine(Thread.CurrentThread.Name + " tyring to acquire lock on " + ((Account)lock1).ID);
            lock (lock1) {
                Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + ((Account)lock1).ID);
                Console.WriteLine(Thread.CurrentThread.Name + " suspended for 1 sec");
                Thread.Sleep(1000);
                Console.WriteLine(Thread.CurrentThread.Name + " back in action and trying to acquire lock on " + ((Account)lock2).ID);
                lock (lock2) {
                    Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + ((Account)lock2).ID);
                    _fromAccount.Withdraw(_amountToTransfer);
                    _toAccount.Deposit(_amountToTransfer);
                    Console.WriteLine(Thread.CurrentThread.Name + " transferd " + _amountToTransfer + " from " + _fromAccount.ID.ToString() + " to " + _toAccount.ID.ToString());
                }
            }
        }
 
        public void TransferDeadLock() {
            Console.WriteLine(Thread.CurrentThread.Name + " trying to acquire lock on " + _fromAccount.ID.ToString());
            lock (_fromAccount) {
                Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + _fromAccount.ID.ToString());
                Console.WriteLine(Thread.CurrentThread.Name + " suspended for 1 sec");
                Thread.Sleep(1000);
                Console.WriteLine(Thread.CurrentThread.Name + " back in action and trying to acquire lock on " + _toAccount.ID.ToString());
                lock (_toAccount) {
                    Console.WriteLine("This code will not be executed");
                    _fromAccount.Withdraw(_amountToTransfer);
                    _toAccount.Deposit(_amountToTransfer);
                }
            }
        }
    }
}
/*
main started
T1 tyring to acquire lock on 101
T1 acquired lock on 101
T1 suspended for 1 sec
T2 tyring to acquire lock on 101
T1 back in action and trying to acquire lock on 102
T1 acquired lock on 102
T1 transferd 1000 from 101 to 102
T2 acquired lock on 101
T2 suspended for 1 sec
T2 back in action and trying to acquire lock on 102
T2 acquired lock on 102
T2 transferd 2000 from 102 to 101
main completed
 
mainstarted
T1 trying to acquire lock on 101
T1 acquired lock on 101
T1 suspended for 1 sec
T2 trying to acquire lock on 102
T2 acquired lock on 102
T2 suspended for 1 sec
T1 back in action and trying to acquire lock on 102
T2 back in action and trying to acquire lock on 101
*/
LINQ, Anonymous Method, Lambda Expression, Func Delegate
            // LINQ
            string[] PersonList = { "Joe", "Janet", "Peet", "Kelly", "Tom", "Aliz" };
            IEnumerable<string> query1 = from p in PersonList 
                                         where p.Length >= 4
                                         orderby p
                                         select p;
            IEnumerable<string> query2 = PersonList.Where(p => p.Length >= 4)
                                                   .OrderBy(p => p)
                                                   .Select(p => p);
 
            List<Employee> listEmployees = new List<Employee>() {
                new Employee {ID = 101, Name = "Mark" },
                new Employee {ID = 102, Name = "John" },
                new Employee {ID = 103, Name = "Mary" },
            };
                       
            Predicate<Employee> EmpPredicate = new Predicate<Employee>(FindEmployee); // Step 2 (delegate)
            Employee res = listEmployees.Find(emp => FindEmployee(emp));  // Step 3
            Console.WriteLine(res.ID + res.Name);
 
            // Anonymous method
            Employee res2 = listEmployees.Find(delegate (Employee emp) { return emp.ID == 102; });
 
            // Lambda Expression
            Employee res3 = listEmployees.Find( Emp => Emp.ID == 102);
 
            // Explicitly specified
            Employee res4 = listEmployees.Find((Employee Emp) => Emp.ID == 102);
 
            // Func Delegate
            Func<Employee, string> selector = employee => "Name = " + employee.Name;
            IEnumerable<string> names = listEmployees.Select(selector);
 
            Func<int, int, string> funcDelegate = (first, second) => "Sum=" + (first + second).ToString();
            Console.WriteLine(funcDelegate(10,20));
Extension Method
 
        WriteColor("ID: " + res4.ID + "Name: " + res4.Name + "\n", ConsoleColor.Yellow, ConsoleColor.DarkRed);
 
        public static void WriteColor(this object element, ConsoleColor fgc, ConsoleColor bgc) {
            Console.ForegroundColor = fgc;
            Console.BackgroundColor = bgc;
            Console.Write(element);
        }
LINQ to SQL, Entity Framework etc
 
 
