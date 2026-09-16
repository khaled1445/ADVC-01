using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace ADVC_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: What is a generic class? Why use generics?
            // it's a class that can work with any data type (also can have a non generic data types). Generics allow you to create classes and methods that can operate on different types.
            // By using generics, you can avoid code duplication and create reusable , easy maintainable components that can work with various data types without risking type safety.
            #endregion

            #region Q2: Write a generic class Container<T> with Add and Get methods.
            //Container<int> containerInt = new Container<int>();
            //containerInt.AddValue(42);
            //Console.WriteLine(containerInt.GetValue());

            //Container<string> containerString = new Container<string>();
            //containerString.AddValue("Hello");
            //Console.WriteLine(containerString.GetValue());

            #endregion

            #region  Q3: What are multiple type parameters? Write Pair<TKey, TValue>.
            // it's a generic class that can take multiple types of parameters, it allows you to define a class that can work with different types of data.
            //Pair<int, string> pair = new Pair<int, string>(1, "khaled");
            //Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            #endregion

            #region  Q4: What is a generic method? Write Swap < T > method.
            // it's a method that can use generic type parameters, allowing it to work with different data types.
            //public static void swap<T>(ref T a, ref T b) 
            //{
            //    T temp = a;
            //    a = b;
            //    b = temp;
            //}
            #endregion

            #region  Q5: Write a generic method FindMax < T > that finds maximum value
            // static T FindMax<T>(T a, T b) where T : IComparable<T>
            //{
            //    return a.CompareTo(b) > 0 ? a : b;
            //}
            //Console.WriteLine(FindMax<int>(5, 10));
            #endregion

            #region  Q6: What is a generic interface? Write IRepository<T>.
            //it's an interface that can use generic type parameters, allowing it to define a contract for classes that can work with different data types.

            #endregion

            #region  Q7: What is the 'struct' constraint? Write an example.
            // it's a constraint that put a rule on the generic type parameter to be a value type (struct).
            // public class ValueTypeContainer<T> where T : struct
            #endregion

            #region  Q8: What is the 'class' constraint? Write an example.
            // it's a constraint that put a rule on the generic type parameter to be a reference type (class).
            // public class ReferenceTypeContainer<T> where T : class
            #endregion

            #region  Q9: What is the 'new()' constraint? Write an example. 
            //it's a constraint that put a rule on the generic type parameter to have a parameterless constructor.
            // public class ParameterlessConstructorContainer<T> where T : new()
            #endregion

            #region  Q10: What is the interface constraint? Write an example.
            //it's a constraint that put a rule on the generic type parameter to implement a specific interface, so you can use the methods defined in that interface.
            // public class InterfaceConstraintContainer<T> where T : IDisposable


            #endregion

            #region   Q11: What is the base class constraint? Write an example.
            // it's a constraint that put a rule on the generic type parameter to inherit from a specific bse class.
            // public class BaseClassConstraintContainer<T> where T : MyBaseClass
            #endregion

            #region  Q12: How do you apply multiple constraints? Write an example.
            //public class MultipleConstraintsContainer<T> where T : class, IDisposable, new()
            // you can apply multiple constraints by separating them with commas, but they mustn't conflict. 
            #endregion

            #region  Q13: What does the 'default' keyword do in generics?
            // it returns the default value for the given type parameter whatever the type is.
            #endregion

            #region  Q14: Write a SafeList < T > that returns default when the index is invalid.
            //
            #endregion

            #region  Q15: What is covariance? Explain the 'out' keyword.
            //

            #endregion

            #region  Q16: What is contravariance? Explain the 'in' keyword.
            //

            #endregion

            #region  Q17: What is the difference between covariance and contravariance? 
            //
            #endregion

            #region  Q18: How do static members work in generic types?
            //

            #endregion

            #region Q19: How can you inherit from a generic class?
            //
            #endregion

            #region Q20: Complete Exercise -Create a generic Cache < TKey, TValue>with Add, Get, Remove, Contains, and expiration support
            //

            #endregion
        }

    }
}
