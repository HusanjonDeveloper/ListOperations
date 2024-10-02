using ListProject.Manager;

class Program
{
    static void Main(string[] args)
    {
        ListManager listManager = new ListManager();

        // Listga elementlar qo'shish
        listManager.AddNumber(5);
        listManager.AddNumber(3);
        listManager.AddNumber(9);
        listManager.AddNumber(1);

        // Listni ko'rsatish
        listManager.DisplayList();

        // Ma'lum indexga element qo'shish
        listManager.InsertNumber(2, 7);
        listManager.DisplayList();

        // Listni sortlash
        listManager.SortList();
        listManager.DisplayList();

        // Elementni index orqali topish
        listManager.FindIndex(7);
        listManager.FindIndex(10);

        // Listdan elementni olib tashlash
        listManager.RemoveNumber(3);
        listManager.DisplayList();
    }
}