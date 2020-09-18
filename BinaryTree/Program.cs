using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = new BinaryTree<string>();

            A.Add("Зеленый");
            A.Add("Синий");
            A.Add("Оранжевый");
            A.Add("Желтый");
            A.Add("Красный");
            A.Add("Фиолетовый");
            A.Add("Голубой");

            A.PrintTree();
        }
    }
}
