namespace LeetCodeSolutions
{
    internal class CategorizeBoxCtiteria
    {
        public string CategorizeBox(int length, int width, int height, int mass)
        {
            string category = "";
            if (IsBulky(length, width, height, mass))
                category += "Bulky";
            if (mass >= 100)
                category += "Heavy";
            if (category == "BulkyHeavy")
                return "Both";
            if (string.IsNullOrEmpty(category))
                return "Neither";
            return category;
        }

        private static bool IsBulky(int length, int width, int height, int mass)
            => length >= Math.Pow(10, 4) || width >= Math.Pow(10, 4) || height >= Math.Pow(10, 4) || (long)length * width * height >= Math.Pow(10, 9);
    }
}
