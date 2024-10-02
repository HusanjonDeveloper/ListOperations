namespace ListProject.Manager;

public class ListManager
    {
        private List<int> numbers;

        // Constructor: List yaratish
        public ListManager()
        {
            numbers = new List<int>();
        }

        // Listga element qo'shish
        public void AddNumber(int number)
        {
            numbers.Add(number);
            Console.WriteLine($"{number} added to the list.");
        }

        // Listdan elementni olib tashlash
        public void RemoveNumber(int number)
        {
            if (numbers.Remove(number))
            {
                Console.WriteLine($"{number} removed from the list.");
            }
            else
            {
                Console.WriteLine($"{number} not found in the list.");
            }
        }

        // Ma'lum indexga element qo'shish
        public void InsertNumber(int index, int number)
        {
            if (index >= 0 && index <= numbers.Count)
            {
                numbers.Insert(index, number);
                Console.WriteLine($"{number} inserted at index {index}.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        // Listni sortlash
        public void SortList()
        {
            numbers.Sort();
            Console.WriteLine("List sorted.");
        }

        // Listdagi elementlarni ko'rsatish
        public void DisplayList()
        {
            Console.WriteLine("Current List:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        // Elementning indexini olish
        public void FindIndex(int number)
        {
            int index = numbers.IndexOf(number);
            if (index != -1)
            {
                Console.WriteLine($"{number} found at index {index}.");
            }
            else
            {
                Console.WriteLine($"{number} not found in the list.");
            }
        }
    }