public class ExampleClass
{
    public int? MyProperty { get; set; }

    public void MyMethod()
    {
        // Check for null before accessing the member
        int value = MyProperty.HasValue ? MyProperty.Value.ToString().Length : 0; 
    }
}