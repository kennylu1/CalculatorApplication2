namespace FileIOApplication
{
     class Program
    {
        static void Main(string[] args)
            /*FileStream：提供了一個字節流，用於讀寫文件。*/
/*參數解釋：

"test.dat"：
文件的名稱。如果文件不存在，則會創建一個新的文件。
FileMode.OpenOrCreate：
如果文件存在，就打開它；如果文件不存在，就創建它。
FileAccess.ReadWrite：
允許對文件進行讀取和寫入操作。*/

{
FileStream F = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
for (int i = 1;i<=20;i++) {
    F.WriteByte((byte)i);
}
F.Position = 0;
for (int i = 0;i<=20;i++) {

Console.Write(F.ReadByte()+" ");
/*為什麼需要兩個 for 循環？
1. 寫入與讀取是分開的操作
寫入數據到文件和從文件讀取數據是兩個獨立的操作。
第一個 for 負責向文件中寫入數據。
第二個 for 負責讀取文件中的數據。*/
}
F.Close();
Console.ReadKey();
}
}
}