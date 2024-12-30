using System;
using System.Reflection;

namespace BugFixApplication
{
    // 定義自訂屬性 DeBugInfo，允許多次使用於類、建構函數、字段、方法和屬性
    [AttributeUsage(AttributeTargets.Class |
       AttributeTargets.Constructor |
       AttributeTargets.Field |
       AttributeTargets.Method |
       AttributeTargets.Property,
       AllowMultiple = true)] // 允許在同一成員上應用多次
    public class DeBugInfo : System.Attribute
    {
        // 私有字段，儲存屬性參數
        private int bugNo;            // Bug 編號
        private string developer;     // 修復 Bug 的開發人員
        private string lastReview;    // 最後審核日期
        public string message;        // 訊息字段

        // 屬性建構函數，初始化必填參數
        public DeBugInfo(int bg, string dev, string d)
        {
            this.bugNo = bg;          // 初始化 Bug 編號
            this.developer = dev;     // 初始化開發人員名稱
            this.lastReview = d;      // 初始化最後審核日期
        }

        // 提供公用的只讀屬性，用於訪問私有字段
        public int BugNo
        {
            get { return bugNo; }
        }

        public string Developer
        {
            get { return developer; }
        }

        public string LastReview
        {
            get { return lastReview; }
        }

        // 提供可讀寫屬性，允許外部修改訊息
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }

    // 為 Rectangle 類添加多個 DeBugInfo 屬性
    [DeBugInfo(45, "Zara Ali", "12/8/2012", Message = "Return type mismatch")]
    [DeBugInfo(49, "Nuha Ali", "10/10/2012", Message = "Unused variable")]
    class Rectangle
    {
        // 成員變數，表示矩形的長度和寬度
        protected double length;
        protected double width;

        // 建構函數，初始化矩形的長度和寬度
        public Rectangle(double l, double w)
        {
            length = l; // 設置長度
            width = w;  // 設置寬度
        }

        // 為 GetArea 方法添加 DeBugInfo 屬性
        [DeBugInfo(55, "Zara Ali", "19/10/2012", Message = "Return type mismatch")]
        public double GetArea()
        {
            return length * width; // 返回矩形面積
        }

        // 為 Display 方法添加 DeBugInfo 屬性
        [DeBugInfo(56, "Zara Ali", "19/10/2012")]
        public void Display()
        {
            // 顯示矩形的長度、寬度和面積
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    // 程式入口類，執行 Rectangle 類的邏輯
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            // 創建 Rectangle 物件並初始化
            Rectangle r = new Rectangle(4.5, 7.5);

            // 調用 Display 方法，輸出矩形資訊
            r.Display();

            // 使用反射獲取 Rectangle 類型
            Type type = typeof(Rectangle);

            // 遍歷 Rectangle 類的自訂屬性
            foreach (Object attributes in type.GetCustomAttributes(false))
            {
                // 將屬性轉換為 DeBugInfo 類型
                DeBugInfo dbi = (DeBugInfo)attributes;

                // 如果屬性不為空，輸出屬性內容
                if (null != dbi)
                {
                    Console.WriteLine("Bug no: {0}", dbi.BugNo);
                    Console.WriteLine("Developer: {0}", dbi.Developer);
                    Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
                    Console.WriteLine("Remarks: {0}", dbi.Message);
                }
            }

            // 遍歷 Rectangle 類的所有方法
            foreach (MethodInfo m in type.GetMethods())
            {
                // 遍歷每個方法的自訂屬性
                foreach (Attribute a in m.GetCustomAttributes(true))
                {
                    // 將屬性轉換為 DeBugInfo 類型
                    DeBugInfo dbi = (DeBugInfo)a;

                    // 如果屬性不為空，輸出屬性內容
                    if (null != dbi)
                    {
                        Console.WriteLine("Bug no: {0}, for Method: {1}", dbi.BugNo, m.Name);
                        Console.WriteLine("Developer: {0}", dbi.Developer);
                        Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
                        Console.WriteLine("Remarks: {0}", dbi.Message);
                    }
                }
            }

            // 等待用戶輸入以結束程式
            Console.ReadLine();
        }
    }
}
