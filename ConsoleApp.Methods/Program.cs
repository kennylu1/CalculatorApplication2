using System.ComponentModel.DataAnnotations; // 引入 System.ComponentModel.DataAnnotations 命名空間（此程式未使用到）。

Console.WriteLine("************* - Methods - *************"); // 打印方法演示的分隔標題。

// void methods - complete a task without returning a value
void PrintName() // 定義一個無返回值的方法 PrintName。
{
    // Method code
    Console.WriteLine("Trevoir"); // 打印固定名稱 "Trevoir" 到控制台。
}

// value returning methods - returns a value after an operation
int GetFiveYearsAgo() // 定義一個有返回值的方法 GetFiveYearsAgo，返回整數。
{
    int year = DateTime.Now.AddYears(-5).Year; // 計算當前年份減去 5 年的年份。
    return year; // 返回計算結果。
}

// methods with parameters - represent data being passed into a method.
void PrintNameWithParams(string name) // 定義一個帶參數的方法 PrintNameWithParams，接受一個字符串參數 name。
{
    // Method code
    Console.WriteLine("You name is: " + name); // 打印 "You name is: [name]"。
}

int GetYearDifferenceWithParams(int year) // 定義一個帶參數的方法 GetYearDifferenceWithParams，返回年份差。
{
    int yearDifference = DateTime.Now.Year - year; // 計算當前年份與傳入年份的差值。
    return yearDifference; // 返回年份差。
}

// methods with optional parameters - parameter is not required..also has a default value
int GetFutureOrPastYear(int numberOfYears = 0) // 定義一個帶可選參數的方法 GetFutureOrPastYear，默認值為 0。
{
    var year = DateTime.Now.AddYears(numberOfYears).Year; // 計算當前年份加上或減去 numberOfYears 的年份。
    return year; // 返回計算結果。
}

// methods with nullable parameters
void PrintNameNullableParam(string? name, int? count) // 定義一個帶可空參數的方法 PrintNameNullableParam。
{
    // 判斷 name 是否為 null，若為 null 則設為 "Default Name"。
    name ??= "Default Name";
    // 判斷 count 是否為 null，若為 null 則設為 1。
    count ??= 1;

    for (int i = 0; i < count; i++) // 使用 for 迴圈，根據 count 值重複打印 name。
    {
        Console.WriteLine(name); // 打印 name。
    }
}

/* Function Calls */
PrintName(); // 調用 PrintName 方法，打印固定名稱 "Trevoir"。

int fiveYearsAgo = GetFiveYearsAgo(); // 調用 GetFiveYearsAgo 方法，將返回值存入變數 fiveYearsAgo。
Console.WriteLine("Five Years Ago was: " + fiveYearsAgo); // 打印 "Five Years Ago was: [fiveYearsAgo]"。

Console.WriteLine("Enter your name"); // 提示用戶輸入姓名。
string name1 = Console.ReadLine(); // 接收用戶輸入的姓名並存儲到變數 name1。
PrintNameWithParams(name1); // 調用 PrintNameWithParams 方法，打印 "You name is: [name1]"。

Console.WriteLine("Enter a year"); // 提示用戶輸入年份。
int pastYear = Convert.ToInt32(Console.ReadLine()); // 將用戶輸入的年份轉換為整數並存儲到 pastYear。
int yearsAgo = GetYearDifferenceWithParams(pastYear); // 調用 GetYearDifferenceWithParams 計算年份差。
Console.WriteLine("This was " + yearsAgo + " years ago"); // 打印 "This was [yearsAgo] years ago"。

Console.WriteLine("Enter number of years in the future or past"); // 提示用戶輸入年份偏移量。
int numberOfYears = Convert.ToInt32(Console.ReadLine()); // 將用戶輸入的偏移量轉換為整數並存儲到 numberOfYears。

var pastYear1 = GetFutureOrPastYear(); // 調用 GetFutureOrPastYear 方法（使用默認偏移量 0）。
Console.WriteLine("The year is: " + pastYear1); // 打印 "The year is: [pastYear1]"。

var pastYear2 = GetFutureOrPastYear(numberOfYears); // 調用 GetFutureOrPastYear 方法，傳入用戶輸入的偏移量。
Console.WriteLine("The year is: " + pastYear2); // 打印 "The year is: [pastYear2]"。

PrintNameNullableParam(null, null); // 調用 PrintNameNullableParam 方法，傳入 null 作為參數，打印默認名稱 "Default Name" 一次。
PrintNameNullableParam("Chester", 5); // 調用 PrintNameNullableParam 方法，傳入 "Chester" 和 5，打印 "Chester" 五次。
