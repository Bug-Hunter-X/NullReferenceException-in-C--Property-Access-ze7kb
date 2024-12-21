public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a null reference will throw a NullReferenceException
        int value = MyProperty.ToString().Length; //Potential NullReferenceException
    }
}