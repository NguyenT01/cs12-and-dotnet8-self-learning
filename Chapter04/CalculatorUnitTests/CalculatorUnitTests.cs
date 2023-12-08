using CalculatorLib;    // Import namespace và class mà ta muốn test chúng

namespace CalculatorUnitTests;
public class CalculatorUnitTests
{
    [Fact]
    public void TestAdding2And2()
    {
        // ARRANGE: Khởi tạo input và các unit trước khi test
        double a = 2;
        double b = 2;
        double expected = 4;
        Calculator calc = new();

        // ACT: Thực thi các hàm để test
        double actual = calc.Add(a, b);

        // ASSERT: Gọi Assert.Equal() để so sánh và đối chiếu 
        // giữa giá trị mong muốn và giá trị thực 
        Assert.Equal(expected, actual);

    }

    [Fact]
    public void TestAdding2And3()
    {
        double a = 2;
        double b = 3;
        double expected = 5;
        Calculator calc = new();

        double actual = calc.Add(a, b);

        Assert.Equal(expected, actual);
    }
}