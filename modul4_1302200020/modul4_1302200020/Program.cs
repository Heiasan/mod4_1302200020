using modul4_13022200020;

namespace modul4_1302200020
{
    public class MainClass
    {
        public static void Main(string[] args)
        {

            Penjumlahan.JumlahTigaAngka<long>(13, 02, 20);
            SimpleDataBase<long> objData1 = new SimpleDataBase<long>();
            objData1.AddNewData(13);
            objData1.AddNewData(02);
            objData1.AddNewData(20);
            objData1.PrintAllData();
        }
    }
}