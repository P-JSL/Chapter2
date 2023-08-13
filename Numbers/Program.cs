// See https://aka.ms/new-console-template for more information
uint naturalNumber = 23; //부호없는 정수
int intergerbNumber = -23; // 정수 (음 또는 양, 0)
float realnumber = 2.3F; //단정밀도 부동 소수점, F접미사시 flot리터럴
double anotherRealNumber = 2.3; // 배정밀도 부동 소수점

//숫자 200만을 저장하는 3가지 변수
int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadedcimalNotation = 0x_001E_8480;

//3개 변수가 모두 같은 값이면 true;
Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine($"{decimalNotation == hexadedcimalNotation}");

//숫자 형식 범위 살펴보기
Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}");
Console.WriteLine($"double uses {sizeof(double)} bytes and can stroe numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can stroe numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}");